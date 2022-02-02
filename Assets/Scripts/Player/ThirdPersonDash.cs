using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonDash : MonoBehaviour
{
    ThirdPersonMovement moveScript;
    public float dashSpeed;
    public float dashTime;
    public float dashCD;
    public GameObject dashEffect;
    void Start()
    {
        moveScript = GetComponent<ThirdPersonMovement>();
    }


    void Update()
    {
        dashCD -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(dashCD <= 0)
            {
                StartCoroutine(Dash());
                FindObjectOfType<AudioManager>().Play("Dash");
                Instantiate(dashEffect, transform.position, transform.rotation);
            }
        }
    }

    IEnumerator Dash()
    {
        float startTime = Time.time;

        while(Time.time < startTime + dashTime)
        {
            moveScript.controller.Move(moveScript.moveDir * dashSpeed * Time.deltaTime);
            dashCD = 1.2f;
            yield return null;
        }
    }
}
