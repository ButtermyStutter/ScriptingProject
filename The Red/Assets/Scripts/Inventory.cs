using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> Items = new List<InventoryItem>(); // Generates a list of Inventory Items, called Items


    public Transform g_inventoryPanel;  // Reference to InventoryUI graphic (panel) 
    private List<SlotUI> g_slots = new List<SlotUI>();

    void Awake()
    {
        foreach (Transform slotGraphic in g_inventoryPanel)
        {
            g_slots.Add(slotGraphic.GetComponent<SlotUI>());
        }
    }

    public void AddItem(InventoryItem item)
    {
        if (Items.Count < g_slots.Count) // checks there are free  slot
            Items.Add(item);
        foreach (SlotUI slot in g_slots)
        {
            if (slot.Item == null)
            {
                slot.SetItem(item);
                return;
            }
        }
    }
}
