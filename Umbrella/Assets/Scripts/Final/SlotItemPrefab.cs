using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotItemPrefab : MonoBehaviour
{
    public Inventory inventory;
    public Image itemImage;
    public Text itemText;
    // Start is called before the first frame update

    public void ItemSetting(Sprite itemSprite, string txt)
    {
        itemImage.sprite = itemSprite;
        itemText.text = txt;
        if(inventory.items == null)
        {
            itemText.text = "";
        }
    }
}
