using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDroid : MonoBehaviour
{
    public GameObject droid;
    public int rate;
    
    private int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;

        if (counter == rate)
        {
            GameObject.Instantiate(droid, this.transform.position, this.transform.rotation);
            counter = 0;
        }
    }
}
