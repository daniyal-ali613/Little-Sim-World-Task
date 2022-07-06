using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayCoin : MonoBehaviour
{
    int money;

    public void IncreaseMoney(int increment)
    {
        money += increment;
    }

    public void DecreaseMoney(int decrement)
    {
        money -= decrement;
    }

     private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = money.ToString();
    }

}
