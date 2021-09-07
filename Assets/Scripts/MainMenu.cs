using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

///<summary>Creating MainMenu</summary>
public class MainMenu : MonoBehaviour
{
    public Button playButton;

     ///<summary>Initializing game from menu screen</summary>
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
    }

    void Update()
    {

    }
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }
}