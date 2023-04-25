using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlag : MonoBehaviour
{
   private GameManager gm;
   private Renderer rend;
   void Start ()
   {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rend = GetComponent<Renderer>();
        rend.enabled= true;
   }
   void OnTriggerEnter ()
   {
        gm.hasFlag = true;
        rend.enabled = false;
   }
}
