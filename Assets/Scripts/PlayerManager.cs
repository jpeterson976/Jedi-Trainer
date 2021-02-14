using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public HealthSystem health;
    public SteamVR_TrackedController left;
    public SteamVR_TrackedController right;
    public GameObject lightning;
    public GameObject secondSaber;
    public GameObject superForce;

    public int pushForce;
    public float pushCooldown;
    private float pushTimer;

    public bool canSeeFuture;
    public bool unlimitedPower;

    void Start()
    {
        
    }

    void Update()
    {
        if (unlimitedPower)
        {
            GameObject[] droids = GameObject.FindGameObjectsWithTag("Droid");

            foreach (GameObject droid in droids)
            {
                droid.GetComponent<HealthSystem>().Damage(5 * Time.deltaTime);
            }

            health.Damage(3 * Time.deltaTime);
            return;
        }

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

        if (right.triggerPressed)
        {
            if (left.triggerPressed)
            {
                unlimitedPower = true;
                secondSaber.SetActive(true);
                superForce.SetActive(true);
                lightning.SetActive(false);
            }
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
