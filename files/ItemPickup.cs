using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryItem item;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager.Instance.AddItem(item);
            Destroy(gameObject);
        }
    }
}