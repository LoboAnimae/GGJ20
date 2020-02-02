using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject center;
    [SerializeField]
    private GameObject player;
    private Rigidbody2D rb;
    private Vector2 centerPos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 80f;
         rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        centerPos = center.transform.position;
        Vector2 newPos = player.transform.position;
        Vector2 difference = (newPos - centerPos)*-1;
        difference.Normalize();
        rb.velocity =difference*speed*Time.deltaTime;
        Debug.Log(rb.velocity);
      
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player"){
            speed = 200f;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.tag=="Player"){
            speed = 80f;
        }
    }
}
