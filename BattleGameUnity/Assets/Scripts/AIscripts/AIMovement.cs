using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class AIMovement : Agent
{
    private CharacterController controller;
    //the enemies target
    public Transform target;

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

    // Start is called before the first frame update
    void Start()
    {

    }

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
                this.transform.position = respawnPoint.position;
                resurectionTime = Time.time + 3f;
                death = false;
            }
            else
            {
                if (Time.time > resurectionTime)
                { canMove = true; }
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
        sensor.AddObservation(target.localPosition);
        sensor.AddObservation(this.transform.localPosition);
        sensor.AddObservation(controller.velocity);
    }


    public override void OnActionReceived(float[] vectorAction)
    {
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = vectorAction[0];

        if (vectorAction[1] == 2)
        {
            controlSignal.z = 1;
        }
        else
        {
            controlSignal.z = -vectorAction[1];
        }

        controller.Move(controlSignal * walkSpeed * Time.deltaTime);


        float distanceToTarget = Vector3.Distance(this.transform.localPosition, target.localPosition);
        // Reached target
        if (distanceToTarget < 1.42f)
        {
            SetReward(1.0f);
            EndEpisode();
        }

        // Fell of platform
        if (this.transform.localPosition.y < -5)
        {
            EndEpisode();
        }
    }
}
