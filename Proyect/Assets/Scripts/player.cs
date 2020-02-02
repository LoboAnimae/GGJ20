using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player  : MonoBehaviour
{
    public Animator animator;  
    public Rigidbody2D rb;
    public float maxSpeed = 5f;
    public float acceleration = 10f;
    public int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(0.0f, 0.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            Debug.Log("D or Right Arrow Pressed");
            direction = 1;
            animator.SetInteger("Direction", direction);

        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            Debug.Log("A or Left arrow pressed");
            direction = 2;
            animator.SetInteger("Direction", direction);
        }
        if(rb.velocity.magnitude>maxSpeed){
            rb.velocity=rb.velocity.normalized*maxSpeed;
        }
       
        float horizontal = Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * acceleration * Time.deltaTime;
        
        rb.AddForce(new Vector2(horizontal, vertical), ForceMode2D.Impulse);
        
    }
}
