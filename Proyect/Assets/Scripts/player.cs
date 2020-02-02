using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player  : MonoBehaviour
{
    public HealtPlayer healtPlayer;
    public Animator animator;  
    public Rigidbody2D rb;
    public float maxSpeed = 5f;
    public float acceleration = 10f;
    public int direction = 0;
    public bool has = false;

    public GameObject star;
    public bool death = false;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(0.0f, 0.0f);  
    for (int i = 0; i < 7; i++)
    {
        Instantiate(star, new Vector3(Random.Range(-15, 190), Random.Range(-9,80), 0), Quaternion.identity);
        Debug.Log("Instantiated Star");
    }
    

        healtPlayer = FindObjectOfType<HealtPlayer>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.0f, 0.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        if(healtPlayer.playerHealth <= 0){
            death = true;
            animator.SetBool("Death", death);
            wait();
            Destroy(gameObject);

        }

        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            direction = 1;
            animator.SetInteger("Direction", direction);

        }

        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)){
            direction = 4;
            animator.SetInteger("Direction", direction);
        }

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            direction = 3;
            animator.SetInteger("Direction", direction);
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
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

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collided");
        if(other.collider.gameObject.tag == "Star" && (has == false)){
            has = true;
            animator.SetBool("has_star", has);
            other.collider.gameObject.transform.position = new Vector3(0, 0, -11);
        }
        
        
        
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(1.7f);
    }
}
