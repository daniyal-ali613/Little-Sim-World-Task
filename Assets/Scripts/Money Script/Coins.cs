using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
     DisplayCoin display;

    private void Start()
    {
        display = FindObjectOfType<DisplayCoin>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){

            this.gameObject.SetActive(false);
            display.IncreaseMoney(1);
        }
    }
}
