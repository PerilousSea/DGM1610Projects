using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 27;
    public Transform blaster;
    public GameObject lazerBolt;
    // Audio variables
    [SerializeField] private AudioSource blasterAudio;
    


    // Update is called once per frame
    void Update()
    {
        //Initialize HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //keep player in bounds (left)
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //keep player in bounds (right)
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if spacebar is pressed fire lazerBolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            blasterAudio.Play();
            //Create lazerBolt at the blaster transform position maintainin objects at rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
       
    }
    //delete any object with a triger that hits the player
     private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
    }
}
