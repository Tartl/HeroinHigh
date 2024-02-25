using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Item item; // Reference to the item

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon; // Ensure that you are accessing the icon property of the item
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
