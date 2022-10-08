using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody m_Rigidbody;
    public GameObject rocketPos;
    private Fly zNormal;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    void Awake()
    {
        zNormal = rocketPos.GetComponent<Fly>();
    }

    public void OnCollisionEnter(Collision col)
    {

        switch (col.gameObject.tag)
        {
            case "Obstacle":
                zNormal.zRotation = new Vector3(0, 0, 0);
                rocketPos.transform.position = new Vector3(-10.449F, 8.42F, -1.45F);

                break;
            case "Finish":

                m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX;
                break;
        }

    }

}


