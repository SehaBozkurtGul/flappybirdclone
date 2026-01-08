using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour

{
    public GameObject playButton;
    public void Start()
    {
        Debug.Log(playButton.activeInHierarchy);
        playButton.SetActive(true);
        Time.timeScale = 1.0f;


    }
    
    public void PlayGame()
    {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("GameScene");
        
         
       

    }
    public void QuitGame()
    {
        Application.Quit(); 
    }

}
