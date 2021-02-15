using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidTracker : MonoBehaviour
{
    public PlayerManager player;
    public GameObject bossSpawnPoint;
    public GameObject boss;
    public GameObject winMenu;

    public int numberSpawned = 0;
    public int numberKilled = 0;
    public int target = 10;
    public bool bossSpawned = false;

    public bool trainingMode;


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
        if (trainingMode)
        {
            if (numberKilled == 1)
            {
                player.hasWon = true;
                winMenu.SetActive(true);
            }
        }

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

        // signifies the boss has been killed
        if (numberKilled == target + 1)
        {
            player.hasWon = true;
            winMenu.SetActive(true);
        }
    }


}
