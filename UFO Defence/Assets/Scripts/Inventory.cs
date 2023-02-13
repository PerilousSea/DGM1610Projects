using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int daBois; //Keep track of the game score
    public TextMeshProUGUI daBoisText; // reference to a text object to be modified

    // Start is called before the first frame update
    void Start()
    {
        UpdateDaBoisText();
    }

   public void IncreaseDaboisText(int amount)
   {
        daBois += amount;
        UpdateDaBoisText();
   }
    
   public void UpdateDaBoisText()
   {
        daBoisText.text = "DaBois: " + daBois;
   }
}
