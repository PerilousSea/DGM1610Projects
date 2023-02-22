using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison_Boi : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "treasure")
        {
            Destroy(gameObject);
            Debug.Log("YOU GOT A TREASURE!");
        }
    }
}
