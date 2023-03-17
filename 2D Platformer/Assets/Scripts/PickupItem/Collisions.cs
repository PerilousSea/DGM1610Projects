using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private InventoryManager inventoryManager;
    public int scoreToGive;
   
   
    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>(); //basically just gives the item to mushroom player
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.tag == "Spore")
        {
            Debug.Log("Lil' Spore Recieved"); //I'm checking here if the collision worked
            Destroy(other.gameObject); //Pickin up a little spore :)
            inventoryManager.IncreaseInventory();  
        }
         
    }
}
