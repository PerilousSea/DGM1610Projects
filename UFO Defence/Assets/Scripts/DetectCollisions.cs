using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManager;
    public int scoreToGive;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LazerBolt"))
        {
            Destroy(gameObject); //Destroy UFO
            Destroy(other.gameObject); //Destroy LazerBolt
            scoreManager.IncreaseScore(scoreToGive);
        }
        
       
       
    }
}
