using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public HealthSystem health;
    public SteamVR_TrackedController left;
    public SteamVR_TrackedController right;
    public GameObject lightning;

    public int pushForce;
    public float pushCooldown;
    private float pushTimer;

    public bool canSeeFuture;

    void Start()
    {
        
    }

    void Update()
    {
        canSeeFuture = right.padPressed;

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


        if (left.triggerPressed)
        {
            lightning.SetActive(true);
        }
        else
        {
            lightning.SetActive(false);
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
