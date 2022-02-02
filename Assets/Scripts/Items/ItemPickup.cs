using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject doorActivate;
    public GameObject doorActivate2;
    public GameObject doorActivate3;
    public GameObject doorEffect;
    public bool isPickedUp = false;
    public static bool VictoryScreen = false;
    public GameObject victoryScreen;

    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Door")
        {
            if(isPickedUp == true)
            {
                FindObjectOfType<AudioManager>().Play("ExplosionDoor");
                Instantiate(doorEffect, transform.position, transform.rotation);
                Destroy(doorActivate);
                isPickedUp = false;
            }
        }

        if(col.collider.tag == "Door2")
        {
            if(isPickedUp == true)
            {
                FindObjectOfType<AudioManager>().Play("ExplosionDoor");
                Instantiate(doorEffect, transform.position, transform.rotation);
                Destroy(doorActivate2);
                isPickedUp = false;
            }
        }

        if (col.collider.tag == "Door3")
        {
            if (isPickedUp == true)
            {
                FindObjectOfType<AudioManager>().Play("ExplosionDoor");
                Instantiate(doorEffect, transform.position, transform.rotation);
                Destroy(doorActivate3);
                isPickedUp = false;
                FindObjectOfType<AudioManager>().Play("Victory");
                victoryScreen.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Pickup(other);
        }
    }

    public void Pickup(Collider key)
    {
        FindObjectOfType<AudioManager>().Play("Item");
        Instantiate(pickupEffect, transform.position, transform.rotation);
        isPickedUp = true;
        //Destroy(pickupEffect, 2f);
    }
}
