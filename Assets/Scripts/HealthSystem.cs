﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int healRate;
    public float maxHealth;
    public float currentHealth;

    public HealthBar healthBar;
    public GameObject loseMenu;

    void Start()
    {
        currentHealth = maxHealth;
        if (healthBar != null)
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
        if (healthBar != null)
            healthBar.SetHealth(currentHealth);
    }

    public void Damage(float dmg)
    {
        currentHealth -= dmg;
        if (healthBar != null)
            healthBar.SetHealth(currentHealth);

        if (gameObject.tag.Equals("Droid"))
        {
            ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
            ps.Play();
        }
    }

    public bool isDead()
    {
        return currentHealth <= 0;
    }


    void Update()
    {
        if (gameObject.tag.Equals("Player"))
            if (isDead())
            {
                Time.timeScale = 0;
                loseMenu.SetActive(true);
            }
    }
}
