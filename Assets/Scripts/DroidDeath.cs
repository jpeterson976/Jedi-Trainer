using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidDeath : MonoBehaviour
{
    public GameObject camera;

    HealthSystem healthSystem;
    ShootBlaster shootBlaster;

    void Start()
    {
        camera = GameObject.Find("Camera (head)");

        healthSystem = GetComponent<HealthSystem>();
        shootBlaster = GetComponent<ShootBlaster>();
    }

    public void FixedUpdate()
    {
        if (healthSystem.isDead())
        {
            camera.GetComponent<DroidTracker>().numberKilled++;
            Destroy(this.gameObject);
        }
    }
}
