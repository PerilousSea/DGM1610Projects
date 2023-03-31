using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public TextMeshProUGUI inventoryText;
    int inventory = 0;
    void Start()
    {
        inventoryText.text = "Spores: " + inventory.ToString();
    }
    public void IncreaseInventory()
    {
        inventory += 1;
        inventoryText.text = "Spores: " + inventory.ToString();
    }
    /*
    public int inventory;
    public TextMeshProUGUI inventoryText;
    public int amount = 3;
    public void IncreaseInventory(int amount)
    {
        inventory += amount;
        UpdateInventoryText();
    }
   
    public void UpdateInventoryText()
    {
        inventoryText.text = "Inventory: " + inventory;
    }
    */
}
