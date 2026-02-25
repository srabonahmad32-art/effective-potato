using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public List<InventoryItem> items = new List<InventoryItem>();

    void Awake()
    {
        Instance = this;
    }

    public void AddItem(InventoryItem item)
    {
        items.Add(item);
    }

    public bool HasItem(string itemName)
    {
        return items.Exists(i => i.itemName == itemName);
    }
}