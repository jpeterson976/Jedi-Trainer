using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidDeath : MonoBehaviour
{
    public GameObject player;

    HealthSystem healthSystem;
    ShootBlaster shootBlaster;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        healthSystem = GetComponent<HealthSystem>();
        shootBlaster = GetComponent<ShootBlaster>();
    }

    public void FixedUpdate()
    {
        if (healthSystem.isDead())
        {
            player.GetComponent<DroidTracker>().numberKilled++;
            Destroy(this.gameObject);
        }
    }
}
