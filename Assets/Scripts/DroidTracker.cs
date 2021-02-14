using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidTracker : MonoBehaviour
{

    public GameObject bossSpawnPoint;
    public GameObject boss;

    public int numberSpawned = 0;
    public int numberKilled = 0;
    public int target = 30;
    public bool bossSpawned = false;


    public int numberActive()
    {
        return numberSpawned - numberKilled;
    }

    public bool allSpawned()
    {
        return numberSpawned >= target;
    }

    void FixedUpdate()
    {
        if (!bossSpawned)
        {
            if (numberKilled == target)
            {
                // spawn the boss from the spawn point
                GameObject.Instantiate(boss, bossSpawnPoint.transform.position, bossSpawnPoint.transform.rotation);

                // turn the flag on to stop multiple spawns
                bossSpawned = true;
            }
        }
    }


}
