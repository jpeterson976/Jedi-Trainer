using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidDeath : MonoBehaviour
{
    SpriteRenderer rend;
    HealthSystem healthSystem;
    ShootBlaster shootBlaster;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        healthSystem = GetComponent<HealthSystem>();
        shootBlaster = GetComponent<ShootBlaster>();
    }

    IEnumerator FadeOut()
    {
        float fade;

        for (fade = 1f; fade >= -0.05f; fade -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = fade;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
        
        if (fade <= 0)
            Destroy(gameObject);
    }

    public void Update()
    {
        if (healthSystem.isDead())
        {
            shootBlaster.fireRate = 100000000;
            StartCoroutine(FadeOut());
        }
    }
}
