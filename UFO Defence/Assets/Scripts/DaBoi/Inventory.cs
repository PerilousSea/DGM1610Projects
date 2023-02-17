using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int daBois; //Keep track of the game score
    public TextMeshProUGUI InventoryText; // reference to a text object to be modified

    // Start is called before the first frame update
    void Start()
    {
        UpdateInventoryText();
    }

   public void IncreaseInventoryText(int amount)
   {
        daBois += amount;
        UpdateInventoryText();
   }
    
   public void UpdateInventoryText()
   {
        InventoryText.text = "Inventory: " + daBois;
   }
}
