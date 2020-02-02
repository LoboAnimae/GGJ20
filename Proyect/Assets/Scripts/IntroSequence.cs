using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequence : MonoBehaviour
{
    [SerializeField]
    private GameObject titleAnim;
    private Animator anim;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
      anim = titleAnim.GetComponent<Animator>();
      //animation = anim.
      //anim.Play();
      flag =  false;
    }

    // Update is called once per frame
    void Update()
    {

        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) {
          SceneManager.LoadScene("MainMenu");
        }
      /*if(flag == true) {

      }*/
    }
}
