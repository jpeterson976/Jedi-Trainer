﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterBolt : MonoBehaviour
{
    public float damageAmount = 20f;
    public AudioClip deflectedSound;

    void FixedUpdate()
    {
        transform.position = transform.position + (transform.forward * 25.0f * Time.smoothDeltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        // bolt hits the player
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.GetComponent<HealthSystem>().Damage(damageAmount);
        }

        // bolt hits the lightsaber beam
        if (collision.gameObject.tag.Equals("Player"))
        {
            this.gameObject.GetComponent<AudioSource>().clip = deflectedSound;
            this.gameObject.GetComponent<AudioSource>().Play();

            // change the direction of the bolt
            transform.Rotate(0, 180.0f, 0);
        }

        // bolt hits a droid
        if (collision.gameObject.tag.Equals("Droid"))
        {
            collision.gameObject.GetComponent<HealthSystem>().Damage(damageAmount);
        }
    }
}
