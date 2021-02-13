using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject highlight;

    private float throwForce = 2.0f;
    private Rigidbody rb;
    private bool thrown = false;

    // Start is called before the first frame update
    void Start()
    {
        highlight.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select()
    {
        highlight.SetActive(true);
    }

    public void Deselect()
    {
        highlight.SetActive(false);
    }

    public void Yeet()
    {
        if (thrown)
            return;

        thrown = true;
        GameObject droid = GameObject.FindWithTag("Droid");
        Vector3 throwDir = droid.transform.position - this.transform.position;
        throwDir.y += 5;

        rb.AddForce(throwDir * throwForce, ForceMode.Impulse);
    }
}
