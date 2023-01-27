using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public int clickToPop = 3;
    public float scaleToIncrease = 0.10f; //scale to increse each time the balloon is clicked


    // Start is called before the first frame update
    void Start()
    {

    }
        
    

    void OnMouseDown()
    {
        clickToPop --;  //reduce click by one
        //Inflate balloon
        transform.localScale += Vector3.one * scaleToIncrease;
        // Check to see if click to pop has reached zero
        
        if(clickToPop == 0)
        {
            Destroy(gameObject); //destroy the balloon as well as remove it
        }
    }
    
}
