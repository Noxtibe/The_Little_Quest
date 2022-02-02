using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    ThirdPersonMovement secondMoveScript;
    public GameObject trailEffect;

    void Start()
    {
        secondMoveScript = GetComponent<ThirdPersonMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(secondMoveScript.speed >= 1)
        {
            Instantiate(trailEffect, transform.position, transform.rotation);
        }
    }
}
