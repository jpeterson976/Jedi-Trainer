using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDroid : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public GameObject droid;
    public int rate;

    private int counter = 0;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    void FixedUpdate()
    {
        counter++;

        // if we have reached the spawn rate count...
        if (counter == rate)
        {
            // if there are less than 10 active droids and not all have been spawned yet...
            if (player.GetComponent<DroidTracker>().numberActive() < 5 && 
                !(player.GetComponent<DroidTracker>().allSpawned()))
            {
                // spawn a new droid, count it, and reset the rate counter for this spawn point
                GameObject.Instantiate(droid, this.transform.position, this.transform.rotation);
                player.GetComponent<DroidTracker>().numberSpawned++;
            }

            counter = 0;
        }
    }
}
