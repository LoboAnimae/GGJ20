using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverPanel;
    private bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
      gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(gameOver) {
        gameOverPanel.SetActive(true);
      }
    }

    public void retrySelected() {
      SceneManager.LoadScene("Main_Scene");
    }

    public void quitSelected() {
      SceneManager.LoadScene("MainMenu");
    }
}
