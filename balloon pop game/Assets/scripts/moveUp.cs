using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperbound = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //make balloon float upward
       transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
       if(transform.position.y > upperbound)
       {
            Destroy(gameObject);
            
       }
    }
}
