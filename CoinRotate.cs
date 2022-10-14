using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{

    private float speed = 27F;
    void Start()
    {

    }


    void Update()
    {


        transform.Rotate(0.0F, 0.0F, speed * Time.deltaTime);

    }
}
