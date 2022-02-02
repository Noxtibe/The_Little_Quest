using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKey : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //FindObjectOfType<AudioManager>().Play("Item");
            Destroy(gameObject);
        }
    }
}
