using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public static PauseManager instance;

    public GameObject pausePanel;
    private bool enpausa;
    // Start is called before the first frame update

    void Awake() {
      if(instance == null) {
        instance = this;
      }
    }

    void Start()
    {
      pausePanel.SetActive(false);
      enpausa = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape)) {
        if(enpausa == false) {
          pausePanel.SetActive(true);
          enpausa = true;
        }
        else if(enpausa == true) {
          pausePanel.SetActive(false);
          enpausa = false;
        }
      }
    }

    public void resumeSelected() {
      pausePanel.SetActive(false);
      enpausa = false;
    }

    public void restartSelected() {
      SceneManager.LoadScene("Main_Scene");
    }

    public void quitSelected() {
      SceneManager.LoadScene("MainMenu");
    }
}
