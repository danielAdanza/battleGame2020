using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        //if it is the player then respawn it
        if (other.gameObject.layer == 9)
        {
            other.gameObject.GetComponent<PlayerMovement>().TakeDamage(1000,"scenario", Quaternion.identity);
        } else if (other.gameObject.layer == 11)
        {
            other.gameObject.GetComponent<AIMovement>().TakeDamage(1000, "scenario", Quaternion.identity);
        }
    }
}
