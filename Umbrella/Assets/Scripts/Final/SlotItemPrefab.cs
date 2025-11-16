using UnityEngine;
using UnityEngine.UI;

public class SlotItemPrefab : MonoBehaviour
{
    public Image itemImage;
    public Text itemText;
    // Start is called before the first frame update

    public void ItemSetting(Sprite itemSprite, string txt)
    {
        if (itemImage == null)
            Debug.LogError("ItemImage is null!");
        else
            itemImage.sprite = itemSprite;

        itemImage.sprite = itemSprite;
        itemText.text = txt;
    }
}
