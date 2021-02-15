using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public float damageRate;

    void OnTriggerStay(Collider other)
    {
        GameObject droid = other.gameObject;
        if (droid.tag.Equals("Droid"))
        {
            HealthSystem droidHealth = droid.GetComponentInParent<HealthSystem>();
            droidHealth.Damage(damageRate * Time.deltaTime);
        }
    }
}
