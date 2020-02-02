using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public CinemachineVirtualCamera vc;
    public HealtPlayer hc;
    public player play;
    

    public camera cam;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null) {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateAnimation(){
        play.has = false;
        play.animator.SetBool("has_star", false);
        Debug.Log("Has is " + play.has);
        Debug.Log("Animator is " + false);
    }
    public void reassign(){
        //vc.Follow = FindObjectOfType<Star_animator>().transform;
        Star_animator a = FindObjectOfType<Star_animator>();
        Debug.Log(a.gameObject.name);
        vc.Follow = a.gameObject.transform;
    }
}
