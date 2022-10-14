using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using TMPro;

public class CoinIncrease : MonoBehaviour
{

    public TextMeshProUGUI textTonen;
    public static int amount;
    void Start()
    {


        textTonen.text = "Score: " + amount.ToString();

    }


    public void Collision()
    {
        amount += 1;
        textTonen.text = "Score: " + amount.ToString();

    }

}
