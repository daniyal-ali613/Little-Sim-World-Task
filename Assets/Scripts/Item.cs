using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public  List<Sprite> items = new List <Sprite>();
    public enum ItemType
    {
        Red,
        Green,
        Black,
        Yellow,
        Blue
    }

    public static int GetCost(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.Red:     return 30;
            case ItemType.Green:   return 50;
            case ItemType.Black:   return 25;
            case ItemType.Yellow:  return 20;
        }
    }

    public static Sprite GetSprite(ItemType itemType)
    {
        switch (itemType)
        {
           
            default:
            case ItemType.Red:    return items[0];
            case ItemType.Green:  return items[1];
            case ItemType.Black:  return items[2];
            case ItemType.Yellow: return items[3];
        }
    }
}
