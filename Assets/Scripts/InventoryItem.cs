using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image;
    public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (image != null)
            image.raycastTarget = false;
        else
            Debug.LogWarning("Image component is not assigned in InventoryItem.");

        parentAfterDrag = transform.parent;
        // Assuming the parent of the item is the inventory slot
        transform.SetParent(transform.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (image != null)
            image.raycastTarget = true;
        else
            Debug.LogWarning("Image component is not assigned in InventoryItem.");

        transform.SetParent(parentAfterDrag);
    }
}
