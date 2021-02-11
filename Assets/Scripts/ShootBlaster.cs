using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBlaster : MonoBehaviour
{
    public GameObject blasterBolt;
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

        if (counter == fireRate)
        {
            GameObject.Instantiate(blasterBolt, this.transform.position, this.transform.rotation);
            this.gameObject.GetComponent<AudioSource>().Play();
            counter = 0;
        }
    }
}
