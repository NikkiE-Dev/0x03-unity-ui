using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

///<summary>Creating MainMenu</summary>
public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

     ///<summary>Initializing game from menu screen</summary>
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        quitButton.onClick.AddListener(QuitMaze);
    }

    void Update()
    {
        
    }
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
    }
}