using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int healRate;
    public float maxHealth;
    public float currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }

    public void Heal()
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            return;
        }

        currentHealth += healRate * Time.deltaTime;
        healthBar.SetHealth(currentHealth);
    }

    public void Damage(float dmg)
    {
        currentHealth -= dmg;
        healthBar.SetHealth(currentHealth);
    }

    public bool isDead()
    {
        return currentHealth <= 0;
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Damage(10);
        }

        if (isDead())
        {
            Debug.Log("You Died");
        }
    }
}
