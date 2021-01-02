using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistantAttacks : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed = 10f;
    public int damage = 2;
    public string tagName = "Player1";

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Destroy(this.gameObject, 5);
    }

    private void Update()
    {
        rigidbody.velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        //if it is the player then respawn it
        if (other.gameObject.layer == 9 && other.gameObject.tag != tagName)
        {
            other.gameObject.GetComponent<PlayerMovement>().TakeDamage(damage, this.tagName, this.gameObject.transform.rotation);
        }
    }
}
