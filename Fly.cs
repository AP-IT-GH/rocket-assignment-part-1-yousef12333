using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameObject rocket;
    public Vector3 zRotation;

    float x;
    float y;
    float z;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            rocket.GetComponent<Rigidbody>().velocity = transform.up * 3;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            z -= 0.02F;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            z += 0.02F;
        }
        zRotation += new Vector3(x, y, z);


        transform.eulerAngles = zRotation;
    }

}
