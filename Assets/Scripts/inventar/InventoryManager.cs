using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public int slotsCount = 5; // Number of slots in the inventory bar

    private List<Item> items = new List<Item>();
    private List<InventorySlot> slots = new List<InventorySlot>();
    private RectTransform inventoryRectTransform;

    public GameObject slotPrefab;
    public Transform inventoryParent;
    public Vector3 offsetFromCamera = new Vector3(0, 0.1f, 1.0f); // Offset from the camera

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    void Start()
    {
        CreateSlots();
        PositionInventoryBar();
        EnsureUIAboveAll(); // Ensure the inventory UI is rendered above everything
    }

    void CreateSlots()
    {
        for (int i = 0; i < slotsCount; i++)
        {
            GameObject slotObj = Instantiate(slotPrefab, inventoryParent);
            InventorySlot slot = slotObj.GetComponent<InventorySlot>();
            slots.Add(slot);
        }
    }

    public void Add(Item item)
    {
        if (items.Count < slotsCount)
        {
            items.Add(item);
            UpdateUI();
        }
        else
        {
            Debug.Log("Inventory full!");
        }
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        UpdateUI();
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (i < items.Count)
            {
                slots[i].AddItem(items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    void PositionInventoryBar()
    {
        if (Camera.main != null && inventoryParent != null)
        {
            Camera mainCamera = Camera.main;
            inventoryRectTransform = inventoryParent.GetComponent<RectTransform>();

            // Calculate the position relative to the inventory parent
            Vector3 viewPos = new Vector3(0.5f, 0.1f, 0); // Middle bottom of the screen
            Vector3 worldPos = mainCamera.ViewportToWorldPoint(viewPos);
            Vector3 inventoryBarPosition = worldPos + offsetFromCamera;

            // Set the position of the inventory bar
            inventoryRectTransform.position = inventoryBarPosition;
        }
        else
        {
            Debug.LogError("Main camera or inventory parent not found!");
        }
    }

    void EnsureUIAboveAll()
    {
        // Ensure the inventory UI is rendered above everything
        Canvas canvas = GetComponent<Canvas>();
        canvas.sortingOrder = int.MaxValue;
    }
}