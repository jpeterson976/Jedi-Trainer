using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBlaster : MonoBehaviour
{
    public GameObject blasterBolt;
    public GameObject phantomBolt;
    public int fireRate = 100;

    private GameObject player;
    private int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.LookAt(player.transform);

        counter++;

        if (player.GetComponent<PlayerManager>().canSeeFuture)
        {
            // phantom bolt
            GameObject.Instantiate(phantomBolt, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }

        if (counter == fireRate)
        {
            GameObject.Instantiate(blasterBolt, this.gameObject.transform.position, this.gameObject.transform.rotation);
            this.gameObject.GetComponent<AudioSource>().Play();
            counter = 0;
        }
    }
}
