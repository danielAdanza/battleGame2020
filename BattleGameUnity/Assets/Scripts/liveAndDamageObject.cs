using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveAndDamageObject : MonoBehaviour
{

    public int damage = -20;
    public int lifeTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }

    void OnTriggerEnter(Collider other)
    {
        //if it is the player then respawn it
        if (other.gameObject.layer == 9)
        {
            other.gameObject.GetComponent<PlayerMovement>().TakeDamage(damage, "scenario", Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
