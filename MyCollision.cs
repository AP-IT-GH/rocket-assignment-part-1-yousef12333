using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MyCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject rocketPos;

    private Fly zNormal;
    private NewScene levelLoad;
    private CoinIncrease cash;
    void Start()
    {



    }
    void Awake()
    {
        zNormal = rocketPos.GetComponent<Fly>();
        cash = GetComponent<CoinIncrease>();
        levelLoad = GetComponent<NewScene>();

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
                levelLoad.sceneLoader();
                break;
            case "Coin":
                cash.Collision();
                Destroy(col.gameObject);
                break;

        }

    }

}


