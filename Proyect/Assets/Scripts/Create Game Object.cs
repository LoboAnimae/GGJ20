using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject star;
    
    void Start()
    {
        star = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
