using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tintileo : MonoBehaviour
{
    public float trans;
    public bool again;
    // Start is called before the first frame update
    void Start(){
       gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, trans);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(trans >= 1f){
            again=true;
        }else if(trans <= 0f){
            again=!again;
        }
        if(again){
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, trans -= 0.01f);
        }else if(!again){
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, trans += 0.01f);
        }
    }
}
