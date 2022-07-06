using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Ui_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTamplate;


    private void Awake()
    {
        container = transform.Find("container");
        shopItemTamplate = container.Find("shopItemTemplate");
        shopItemTamplate.gameObject.SetActive(false);
    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTansform = Instantiate(shopItemTamplate, container);
        RectTransform shopItemRectTransform = shopItemTamplate.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemRectTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTansform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTansform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
    }

}
