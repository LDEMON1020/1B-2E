using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class InventoryUI : MonoBehaviour
{
    public SlotItemPrefab SIP;
    public void UpdateInventory(Inventory myInven)
    {
        foreach (var item in myInven.items)
        {
            switch (item.Key)
            {
                case BlockType.Dirt:
                    myInven.Add(BlockType.Dirt, 1);
                    break;
                case BlockType.Grass:
                    myInven.Add(BlockType.Grass, 1);
                    break;
                case BlockType.Water:
                    myInven.Add(BlockType.Water, 1);
                    break;
            }
        }
    }
}
