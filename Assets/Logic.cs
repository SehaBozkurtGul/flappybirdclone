using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq.Expressions;
using TMPro;

public class Logic : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverScreen;
    public TMP_Text gameOverScreenText;
    public static bool isPaused;
    public GameObject pausemenu;
    public Text gameOverScore;
  

    void Start()
    {
        pausemenu.SetActive(false);
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
            Debug.Log("p");
        }


    }
    public void PauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }


    public void GameOver(string causeDeath)
    {
        switch (causeDeath)
        {
            case "tree":
                gameOverScreen.SetActive(true);
                gameOverScreenText.text = "Zort aðaç";
                break;
            case "miniplane": 
                gameOverScreen.SetActive(true);
                gameOverScreenText.text = "kamikaze";
                break;
            default:
                gameOverScreen.SetActive(true);
                gameOverScreenText.text = "Game Over Out of Bounds\r\nBetter Luck Next Time"; 

                break;
        }

        //scoreText.SetActive(false);
        //gameOverScore.text = scoreText.text;
        gameOverScore.text = "Your Score : "+scoreText.text;
       
      
        scoreText.enabled = false;
        
        Time.timeScale = 0f;
        isPaused = true;


    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        isPaused = false;

    }
    public void MainMenu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        pausemenu.SetActive(false);


    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
