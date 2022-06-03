using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class InventoryItem : ScriptableObject
{
    [SerializeField]
    private string g_name = "Enter Item Name...";
    public string Name { get { return g_name; } }

    [SerializeField] // makes private variables show up in the inspector 
    private Sprite g_sprite;
    public Sprite Sprite { get { return g_sprite; } }
}
