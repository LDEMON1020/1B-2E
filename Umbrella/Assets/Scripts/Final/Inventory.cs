using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<BlockType, int> items = new();
    public InventoryUI inventoryUI;
    public Sprite DirtSprite;
    public Sprite GrassSprite;
    public Sprite WaterSprite;
    // Start is called before the first frame update
    private void Start()
    {
        // UI 연결 안 되어 있으면 자동으로 찾기 (선택)
        if (inventoryUI == null)
            inventoryUI = FindObjectOfType<InventoryUI>();
    }
    public void Add(BlockType type, int count = 1)
    {
        if (!items.ContainsKey(type)) items[type] = 0;
        items[type] += count;
        Debug.Log($"[Inventory] +{count} {type} (총 {items[type]})");

        inventoryUI?.UpdateInventory(this);
    }

    public bool Consume(BlockType type, int count = 1)
    {
        if (!items.TryGetValue(type, out var have) || have < count) return false;
        items[type] = have - count;
        Debug.Log($"[Inventory] -{count} {type} (총 {items[type]})");
        inventoryUI?.UpdateInventory(this);
        return true;
    }
}
