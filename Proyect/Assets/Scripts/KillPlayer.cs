﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public HealtPlayer instance;
    public int golpe;
  
    // Start is called before the first frame update
    void Start()
    {
        instance = FindObjectOfType<HealtPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            instance.playerHealth -= golpe;
            instance.Vergazo();
        }
    }
    
        
}
