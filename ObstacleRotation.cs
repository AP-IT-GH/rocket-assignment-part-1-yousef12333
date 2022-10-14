using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation : MonoBehaviour
{

    private float speed = 55F;
    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0.0F, 0.0F);
    }
}
