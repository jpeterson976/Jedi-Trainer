using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterBolt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += transform.forward * 25.0f * Time.smoothDeltaTime;
    }
}
