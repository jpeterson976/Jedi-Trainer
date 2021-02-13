using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    private SteamVR_TrackedController left;

    void Start()
    {
        left = GetComponent<SteamVR_TrackedController>();
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.tag.Equals("Throwable"))
        {
            obj.GetComponent<Throwable>().Select();
        }
    }

    void OnTriggerStay(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.tag.Equals("Throwable"))
        {
            if (left.gripped)
                obj.GetComponent<Throwable>().Yeet();
        }
    }

    void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.tag.Equals("Throwable"))
        {
            obj.GetComponent<Throwable>().Deselect();
        }
    }
}
