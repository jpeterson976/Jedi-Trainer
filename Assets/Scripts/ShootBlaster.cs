using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBlaster : MonoBehaviour
{
    public GameObject blasterBolt;

    private GameObject player;
    private int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.LookAt(player.transform);

        counter++;

        if (counter == 100)
        {
            GameObject.Instantiate(blasterBolt, this.transform.position, this.transform.rotation);
            this.gameObject.GetComponent<AudioSource>().Play();
            counter = 0;
        }
    }
}
