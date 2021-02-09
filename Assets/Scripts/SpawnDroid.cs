using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDroid : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    public GameObject droid;
    public int rate;
    
    private int counter = 0;

    void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Camera (head)");
    }

    void FixedUpdate()
    {
        counter++;

        // if we have reached the spawn rate count...
        if (counter == rate)
        {
            // if there are less than 10 active droids and not all have been spawned yet...
            if (camera.GetComponent<DroidTracker>().numberActive() < 10 && 
                !(camera.GetComponent<DroidTracker>().allSpawned()))
            {
                // spawn a new droid, count it, and reset the rate counter for this spawn point
                GameObject.Instantiate(droid, this.transform.position, this.transform.rotation);
                camera.GetComponent<DroidTracker>().numberSpawned++;
                counter = 0;
            }
        }
    }
}
