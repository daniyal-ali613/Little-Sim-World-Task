using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop_UI : MonoBehaviour
{
    public GameObject ui;
    public List<GameObject> items = new List<GameObject>();
    public List<GameObject> itemCost = new List<GameObject>();
    DisplayCoin display;
    TextMeshProUGUI moneyText;

    TextMeshProUGUI costText0;
    TextMeshProUGUI costText1;
    TextMeshProUGUI costText2;
    TextMeshProUGUI costText3;



    private void Start()
    {
        display = FindObjectOfType<DisplayCoin>();
        moneyText = display.GetComponent<TextMeshProUGUI>();
        costText0 =  itemCost[0].GetComponent<TextMeshProUGUI>();
        costText1 = itemCost[1].GetComponent<TextMeshProUGUI>();
        costText2 = itemCost[2].GetComponent<TextMeshProUGUI>();
        costText3 = itemCost[3].GetComponent<TextMeshProUGUI>();
    }

    public void PurchaseItem1()
    {
        int itemCost;
        int money;
        itemCost = int.Parse(costText0.text);
        money = int.Parse(moneyText.text);

        if(money < itemCost)
        {
            return;
        }

        else
        {
            items[0].SetActive(true);
            display.DecreaseMoney(itemCost);
        }
    }

    public void PurchaseItem2()
    {
        int itemCost;
        int money;
        itemCost = int.Parse(costText1.text);
        money = int.Parse(moneyText.text);

        if (money < itemCost)
        {
            return;
        }

        else
        {
            items[1].SetActive(true);
            display.DecreaseMoney(itemCost);

        }
    }

    public void PurchaseItem3()
    {
        int itemCost;
        int money;
        itemCost = int.Parse(costText2.text);
        money = int.Parse(moneyText.text);

        if (money < itemCost)
        {
            return;
        }

        else
        {
            items[2].SetActive(true);
            display.DecreaseMoney(itemCost);
        }
    }
    public void PurchaseItem4()
    {
        int itemCost;
        int money;
        itemCost = int.Parse(costText3.text);
        money = int.Parse(moneyText.text);

        if (money < itemCost)
        {
            return;
        }

        else
        {
            items[3].SetActive(true);
            display.DecreaseMoney(itemCost);
        }
    }

    public void RemoveUI()
    {
        ui.SetActive(false);
    }

}
