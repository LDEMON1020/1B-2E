using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public List<Transform> Slot = new List<Transform>();
    public GameObject Slotitem;
    List<GameObject> items = new List<GameObject>();

    public void UpdateInventory(Inventory myInven)
    {
        // 기존 슬롯 정리
        foreach (var Slotitems in items)
            Destroy(Slotitems);

        items.Clear();

        int idx = 0;

        foreach (var item in myInven.items)
        {
            if (idx >= Slot.Count)
            {
                Debug.LogWarning("슬롯 개수가 부족합니다!");
                break;
            }

            // 슬롯 아이템 생성
            var go = Instantiate(Slotitem, Slot[idx]);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;

            SlotItemPrefab sitem = go.GetComponent<SlotItemPrefab>();
            items.Add(go);

            // 스프라이트 선택
            Sprite sprite = null;

            switch (item.Key)
            {
                case BlockType.Dirt:
                    sprite = myInven.DirtSprite;
                    break;

                case BlockType.Grass:
                    sprite = myInven.GrassSprite;
                    break;

                case BlockType.Water:
                    sprite = myInven.WaterSprite;
                    break;
            }

            // 슬롯 UI 세팅
            sitem.ItemSetting(sprite, item.Value.ToString());

            idx++;
        }
    }
}