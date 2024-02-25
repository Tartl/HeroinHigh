using UnityEngine;


public class ItemPickup : MonoBehaviour
{
    public Item item; // The item to be added to the inventory

    private void OnMouseDown()
    {
        AddToInventory();
    }

    void AddToInventory()
    {
        InventoryManager.instance.Add(item); // Add the item to the inventory
        Destroy(gameObject); // Destroy the item object after it's picked up
    }
}
