using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasFlag;
    public static GameManager instance;
    void Awake ()
    {
        intance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
       hasFlag = false;
       flagPlaced = false;
       Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(flagPlaced)
        {
            WinGame();
        }
        if(Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }
    public void TogglePauseGame ()
    {
        gamePaused = !gamePaused == true ? 0.0f : 1.0f;
        Time.timeScale = gamePaused == true ? 
    }
}
