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
    //public Button optionsButton;
    //public Button backButton;

    public GameObject mainMenu;
    public GameObject optionsMenu;


     ///<summary>Initializing game from menu screen</summary>
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        quitButton.onClick.AddListener(QuitMaze);
        //optionsButton.onClick.AddListener(OpenOptionsMenu);
        //backButton.onClick.AddListener(OpenMainMenu);
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
        public void OpenOptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void OpenMainMenu()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    
}