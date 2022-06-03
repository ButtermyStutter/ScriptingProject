using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlotUI : MonoBehaviour
{
    public Text g_text; // Holds the item's text 
    public Image g_icon; // Holds the item's image 
    public Button g_button;

    private InventoryItem g_item; // reference to Inventory Item 
    public InventoryItem Item { get { return g_item; } set { g_item = value; } }

    // SET ITEM 
    public void SetItem(InventoryItem item)
    {
        this.g_item = item;
        this.g_text.text = this.g_item.name; //Sets the text field to this item's name 
        this.g_icon.sprite = item.Sprite;
        this.g_button.interactable = true;
    }

    // UNSET ITEM 
}
