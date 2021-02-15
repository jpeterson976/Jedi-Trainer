using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBlaster : MonoBehaviour
{
    public GameObject blasterBolt;
    public GameObject phantomBolt;
    public int fireRate = 100;

    private GameObject player;
    private GameObject target;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        target = GameObject.Find("Camera (eye)");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.LookAt(target.transform);

        counter++;

        if (player.GetComponent<PlayerManager>().canSeeFuture && (counter == fireRate - 60))
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
