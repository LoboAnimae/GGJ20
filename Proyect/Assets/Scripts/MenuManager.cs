using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour, IPointerClickHandler
{

  public static MenuManager instance;

  public GameObject MenuPanel;

  void Awake() {
    if(instance == null) {
      instance = this;
    }
  }

  public void OnPointerClick(PointerEventData eventData) {
    // OnClick code goes here
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
