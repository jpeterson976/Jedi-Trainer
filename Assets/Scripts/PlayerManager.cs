using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public HealthSystem health;
    public SteamVR_TrackedController left;
    public SteamVR_TrackedController right;

    public int pushForce;
    public float pushCooldown;
    private float pushTimer;

    void Start()
    {
        
    }

    void Update()
    {
        if (pushTimer > 0)
        {
            pushTimer -= Time.deltaTime;
        }

        if (right.gripped)
        {
            health.Heal();
        }
        else if (left.padPressed && pushTimer <= 0)
        {
            ForcePush();
            pushTimer = pushCooldown;
        }
    }

    void ForcePush()
    {
        GameObject[] droids = GameObject.FindGameObjectsWithTag("Droid");

        foreach (GameObject droid in droids)
        {
            Rigidbody rb = droid.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * pushForce, ForceMode.Impulse);
        }
    }
}
