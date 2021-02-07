using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public HealthSystem health;
    public SteamVR_TrackedController left;
    public SteamVR_TrackedController right;

    void Start()
    {
        
    }

    void Update()
    {
        if (right.gripped)
        {
            health.Heal();
        }
    }
}
