using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] items;
    public Transform[] spawnPositions;

    private int itemIndex;
    private int spawnIndex;
    private float timeNextItem = 0f;

    void Start()
    {
        pickNextItem();

        Debug.Log(itemIndex);
        Debug.Log(spawnIndex);
        Debug.Log(timeNextItem);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeNextItem)
        {
            pickNextItem();

            Instantiate(items[itemIndex], spawnPositions[spawnIndex].position, Quaternion.identity);

            Debug.Log(itemIndex);
            Debug.Log(spawnIndex);
            Debug.Log(timeNextItem);
        }
    }

    private void pickNextItem()
    {
        itemIndex = Random.Range(0, items.Length);
        spawnIndex = Random.Range(0, spawnPositions.Length);
        timeNextItem = timeNextItem + Random.Range( 8f, 14f );
    }


}
