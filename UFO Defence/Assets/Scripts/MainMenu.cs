using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioSource Click;
    [SerializeField]
    private int sceneToLoad;
    public void StartGame()
    {
        Click.Play();
        SceneManager.LoadScene(sceneToLoad); //Indexed Scene to load
        Debug.Log("New Scene Loaded!");
        
    }
    public void QuitGame()
    {
        Click.Play();
        Application.Quit(); // Quit Game
        Debug.Log("You have quit the game, goodbye!");
    }
  
}
