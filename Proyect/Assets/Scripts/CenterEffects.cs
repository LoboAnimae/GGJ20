using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterEffects : MonoBehaviour
{
    [SerializeField]
    private GameObject center;
    [SerializeField]
    private GameObject particles;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
      gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col) {
      if(col.gameObject.tag == "Player") {
        Debug.Log("Entering collision");
        GameObject part = Instantiate(particles,col.gameObject.transform.position,Quaternion.identity);
        Destroy(col.gameObject);
        Destroy(part,1f);
        gameOver = true;
      }
    }
}
