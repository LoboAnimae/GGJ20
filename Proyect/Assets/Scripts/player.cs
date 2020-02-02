using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float maxSpeed = 5f;
    public float acceleration = 10f;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(0.0f, 0.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude>maxSpeed){
            rb.velocity=rb.velocity.normalized*maxSpeed;
        }
       
        float horizontal = Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * acceleration * Time.deltaTime;

        rb.AddForce(new Vector2(horizontal, vertical), ForceMode2D.Impulse);
        
    }
}
