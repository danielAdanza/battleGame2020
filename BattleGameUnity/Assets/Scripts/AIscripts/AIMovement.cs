using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class AIMovement : Agent
{
    private CharacterController controller;
    //the enemies target
    public Transform[] targets;
    public GameObject thisGameObject;

    public float walkSpeed = 4f;
    public float runSpeed = 8f;
    public int playerNumber = 1;
    public PlayerInputControls controls;
    public float gravity = -9.81f;

    public MarksController marksController;
    public Transform respawnPoint;
    private bool canMove = true;
    private bool death = false;
    private float resurectionTime = 0.0f;

    //for gravity and jumps
    private Vector3 velocity;
    private bool isGrounded = false;
    public Transform groundCheck;
    private bool canJump = true;
    private float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 1f;

    //Player stats
    public int maxHealth;
    public int health;
    public int attack;
    public int distantAttack;
    public GameObject distantAttackObject;
    //it indicates the force that it will be pushed when they attack him
    //2f would be the standard 1.5 would be heavy and 2.5 would be thin
    public float bodyMass = 2f;

    private float horizontal = 0f;
    private float vertical = 0f;
    private bool isRunning = false;
    private float nextAttack = 0f;
    public float coolDownTime = 0.75f;
    public float coolDownMelee = 0.5f;

    //melee attacks
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public string tagName = "Player3";

    void Update()
    {
        if (canMove == true)
        {
            // checking if we are on the ground or not
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
        else
        {
            if (death == true)
            {
                Debug.Log("it entered in death");
                //thisGameObject.transform.position = respawnPoint.position;
                resurectionTime = Time.time + 3f;
                death = false;
            }
            else
            {
                if (Time.time > resurectionTime)
                { canMove = true; }
                else
                { thisGameObject.transform.position = respawnPoint.position; }
            }
        }
    }

    public override void OnEpisodeBegin()
    {

        controller = this.GetComponent<CharacterController>();

        health = maxHealth;
        marksController.SetMaxHealth(maxHealth);

        controls = new PlayerInputControls();
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(targets[0].localPosition);
        sensor.AddObservation(targets[1].localPosition);
        sensor.AddObservation(thisGameObject.transform.localPosition);
        sensor.AddObservation(controller.velocity);
    }

    //vectorAction[0] == 0 means that the player can move if it´s one means the AI decided to move
    //vectorAction[1] can be 0,1,2 for moving the x axis with -1,0 and 1
    //VectorAction[2] can be 0,1,2 for moving the z axis -1,0 and 1
    //VectorAction[3] can be 0,1,2 0 does nothing, 1 attacks melee and 2 makes distant attack
    public override void OnActionReceived(float[] vectorAction)
    {
        if (canMove == false )
        {
            if (death == true)
            {
                controller.Move(respawnPoint.position);
                //thisGameObject.transform.localPosition = respawnPoint.position;
                resurectionTime = Time.time + 3f;
                death = false;
            }
            else
            {
                if (Time.time > resurectionTime)
                {
                    canMove = true;
                }
            }

        }
        else
        {
            //Debug.Log("VectorAction[2]:" + vectorAction[2]);
            //Debug.Log("VectorAction[3]:" + vectorAction[3]);

            //new way of moving
            Vector3 controlSignal = Vector3.zero;

            if (vectorAction[0] == 0)
            {
                controlSignal.x = vectorAction[1] - 1;
                controlSignal.z = vectorAction[2] - 1;
            }

            controller.Move(controlSignal * walkSpeed * Time.deltaTime);

            if (vectorAction[3] == 1)
            {
                //melee attack
                if (nextAttack <= Time.time)
                {
                    nextAttack = Time.time + coolDownMelee;

                    Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange);

                    foreach (Collider enemy in hitEnemies)
                    {
                        //checking if it hits the other players but not the current one
                        if (enemy.gameObject.layer == 9 )
                        {
                            SetReward(attack);
                            enemy.gameObject.GetComponent<PlayerMovement>().TakeDamage(attack, this.tagName, this.gameObject.transform.rotation);
                        }
                        else if (enemy.gameObject.layer == 11 && enemy.gameObject.tag != tagName)
                        {
                            SetReward(attack);
                            enemy.gameObject.GetComponent<AIMovement>().TakeDamage(attack, this.tagName, this.gameObject.transform.rotation);
                        }
                    }
                }
            }
            else if (vectorAction[3] == 2)
            {
                //distant attack
                if (nextAttack <= Time.time)
                {
                    Quaternion rotation = Quaternion.Euler(0, this.transform.eulerAngles.y, 0);
                    Instantiate(distantAttackObject, this.transform.position, rotation);
                    nextAttack = Time.time + coolDownTime;
                }
            }


            float distanceToTarget1 = Vector3.Distance(this.transform.localPosition, targets[0].localPosition);
            float distanceToTarget2 = Vector3.Distance(this.transform.localPosition, targets[1].localPosition);
            // Reached target
            /*if (distanceToTarget1 < 1.42f | distanceToTarget2 < 1.42f)
            {
                SetReward(1.0f);
            }*/
        }

    }

    public void TakeDamage(int damage, string agresorTag, Quaternion rotation)
    {
        SetReward(-damage);

        if (canMove == true)
        {

            health -= damage;

            //after taking damage or recuperating life health should never be less than 0 or more than the maxHealth
            if (health > maxHealth)
            { health = maxHealth; }
            else if (health < 0)
            { health = 0; }

            marksController.SetHealth(health);

            if (health <= 0)
            { respawn(agresorTag); }

            if (damage > 0 & agresorTag != "scenario")
            {
                //calculating the added force depending on the life remaining. The added force will be within 3 and 6:
                //3 would be if you have zero life and 6 is if you have no life remaining
                float forceFromLife = ((3f * health) / maxHealth + 3);
                //they could push different depending on the scenarios
                float scenarioForce = 5f;
                //we get pushed and we give the direction multiplied by the forward vector, we input time.deltaTime so it does not depend on the frames
                //the damage of the attack and the amount of life remaining 
                controller.Move(rotation * Vector3.forward * Time.deltaTime * damage * bodyMass * forceFromLife * scenarioForce);
            }

            if (!canJump & isGrounded)
            {
                canJump = true;
            }
        }

    }

    void respawn(string agresorTag)
    {
        SetReward(-3.0f);

        canMove = false;
        death = true;
        health = maxHealth;
        marksController.resurrection(agresorTag);
    }
}
