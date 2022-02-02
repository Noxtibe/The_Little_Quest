using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject gameOverCanvas;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            FindObjectOfType<AudioManager>().Play("Defeat");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            gameOverCanvas.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Enemy")
        {
            TakeDamage(5);
            FindObjectOfType<AudioManager>().Play("ExplosionEnemy");
            //Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
