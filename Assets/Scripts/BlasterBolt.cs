using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterBolt : MonoBehaviour
{
    public float damageAmount = 20f;
    public AudioClip deflectedSound;

    void FixedUpdate()
    {
        this.gameObject.transform.position += transform.forward * 25.0f * Time.smoothDeltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("trigger enter happens");
        Debug.Log(collision.gameObject.name);
        // bolt hits the player
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("hit the player");
            collision.gameObject.GetComponent<HealthSystem>().Damage(damageAmount);
        }

        // bolt hits the lightsaber beam
        if (collision.gameObject.tag.Equals("beam"))
        {
            Debug.Log("bolt deflected");
            this.gameObject.GetComponent<AudioSource>().clip = deflectedSound;
            this.gameObject.GetComponent<AudioSource>().Play();

            // change the direction of the bolt
            this.gameObject.transform *= -1;
        }
    }
}
