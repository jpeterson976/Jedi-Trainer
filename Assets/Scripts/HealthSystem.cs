using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }

    public void Heal()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }

    public void Damage(int dmg)
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
        else if (Input.GetButtonDown("Horizontal"))
        {
            Heal();
        }

        if (isDead())
        {
            Debug.Log("You Died");
        }
    }
}
