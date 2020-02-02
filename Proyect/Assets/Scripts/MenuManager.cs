using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

  public static MenuManager instance;

  public GameObject MenuPanel;

  void Awake() {
    if(instance == null) {
      instance = this;
    }
  }

  void Start() {
  }

  void Update() {
  }

  public void playSelected() {
    SceneManager.LoadScene("Main_Scene");
  }

  public void quitSelected() {
    Debug.Log("Saliendo del juego");
    Application.Quit();
  }
}
