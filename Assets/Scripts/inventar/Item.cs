using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    // Name of the item
    public string name = "New Item";

    // Icon of the item
    public Sprite icon = null;
}
