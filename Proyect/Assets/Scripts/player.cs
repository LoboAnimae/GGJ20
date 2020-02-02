using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player  : MonoBehaviour
{
    public HealtPlayer healtPlayer;
    public Animator animator;  
    public Rigidbody2D rigidbody_player;
    public float maxSpeed = 10f;
    public float acceleration = 10f;
    public int direction = 0;
    public bool has = false;

    public GameObject star;
    public GameObject hitbox;
    public bool death = false;

    // Start is called before the first frame update
    void Start()
    {
    hitbox = GetComponent<GameObject>();
    Instantiate(hitbox, new Vector3(58, 61, -24), Quaternion.identity);
    Instantiate(hitbox, new Vector3(72, 62, -24), Quaternion.identity);
    Instantiate(hitbox, new Vector3(80, 57, -24), Quaternion.identity);
    Instantiate(hitbox, new Vector3(90, 51, -24), Quaternion.identity);
    Instantiate(hitbox, new Vector3(91, 42, -24), Quaternion.identity);
    Instantiate(hitbox, new Vector3(107, 39, -24), Quaternion.identity);
    Instantiate(hitbox, new Vector3(111, 49, -24), Quaternion.identity);
    rigidbody_player = GetComponent<Rigidbody2D>();
    rigidbody_player.velocity = new Vector2(0.0f, 0.0f);  
    for (int i = 0; i < 7; i++)
    {
        Instantiate(star, new Vector3(Random.Range(-15, 190), Random.Range(-9,80), 0), Quaternion.identity);
        Debug.Log("Instantiated Star");
        
    }
    

    healtPlayer = FindObjectOfType<HealtPlayer>();
    rigidbody_player = GetComponent<Rigidbody2D>();
    rigidbody_player.velocity = new Vector2(0.0f, 0.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(GameManager.instance.hc.playerHealth  < 1){
            death = true;
            animator.SetBool("Death", death);
          
            

        }
        
        */

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
        if(rigidbody_player.velocity.magnitude>maxSpeed){
            rigidbody_player.velocity = rigidbody_player.velocity.normalized*maxSpeed;
        }
       
        float horizontal = Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * acceleration * Time.deltaTime;
        
        rigidbody_player.AddForce(new Vector2(horizontal, vertical), ForceMode2D.Impulse);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.gameObject.tag == "Star" && (has == false)){
            has = true;
            animator.SetBool("has_star", has);
            Destroy(other.collider.gameObject, 0.0f);
        }
    }
}

