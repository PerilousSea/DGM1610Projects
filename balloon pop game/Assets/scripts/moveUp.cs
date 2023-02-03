using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperbound = 10;
    public ScoreManager scoreManager; // Stores a reference to the scoremanager
    public balloon balloon; //reference to balloon script for score

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<balloon>();
    }

    // Update is called once per frame
    void Update()
    {
       //make balloon float upward
       transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
       if(transform.position.y > upperbound)
       {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);//reduces score for allowing the balloon to leave the screen
            Destroy(gameObject); //pops balloon
            
       }
    }
}
