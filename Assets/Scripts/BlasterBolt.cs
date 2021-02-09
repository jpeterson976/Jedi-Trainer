using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterBolt : MonoBehaviour
{

    void FixedUpdate()
    {
        this.gameObject.transform.position += transform.forward * 25.0f * Time.smoothDeltaTime;
    }
}
