using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainerMovement : MonoBehaviour
{
    public GameObject anchor1;
    public GameObject anchor2;
    public GameObject anchor3;
    public GameObject anchor4;

    private int position;
    private float speed;

    private void Start()
    {
        position = 0;
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("position is " + position.ToString());
        float movement = speed * Time.deltaTime;

        switch (position)
        {
            case 0:
                transform.position = Vector3.MoveTowards(this.gameObject.transform.position, anchor2.transform.position, movement);
                if (Vector3.Distance(this.gameObject.transform.position, anchor2.transform.position) < 0.01f)
                {
                    position++;
                }
                break;
            case 1:
                transform.position = Vector3.MoveTowards(this.gameObject.transform.position, anchor3.transform.position, movement);
                if (Vector3.Distance(this.gameObject.transform.position, anchor3.transform.position) < 0.01f)
                {
                    position++;
                }
                break;
            case 2:
                transform.position = Vector3.MoveTowards(this.gameObject.transform.position, anchor4.transform.position, movement);
                if (Vector3.Distance(this.gameObject.transform.position, anchor4.transform.position) < 0.01f)
                {
                    position++;
                }
                break;
            case 3:
                transform.position = Vector3.MoveTowards(this.gameObject.transform.position, anchor1.transform.position, movement);
                if (Vector3.Distance(this.gameObject.transform.position, anchor1.transform.position) < 0.01f)
                {
                    position++;
                }
                break;
            default:
                position = 0;
                break;
        }
    }
}
