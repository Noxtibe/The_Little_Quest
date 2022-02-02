using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    public GameObject deathEffectEnemy;
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Instantiate(deathEffectEnemy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}