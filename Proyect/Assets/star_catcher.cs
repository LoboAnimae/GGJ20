using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_catcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject star_completed;
    public Animator anim;
    public CircleCollider2D cc;
    private CircleCollider2D circleCollider;
    
    void Start()
    {
        cc = GetComponent<CircleCollider2D>();
        anim = GetComponent<Animator>();
        //circleCollider = gameObject.AddComponent<CircleCollider2D>() as CircleCollider2D; 
    }

    // Update is called once per frame
    void Update()
    {
    }
/*
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.gameObject.tag == "player"){
            Instantiate(star_completed, new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
            Destroy(other.gameObject, 0.1f);
            animator.SetBool("collided_with_star", true);
            gameManager.player.animator.SetBool("has_star", false);

        }
    }
    */

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.tag + " has collided with" + gameObject.tag);
        if(other.gameObject.tag == "Player"){
            
            Instantiate(star_completed, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            //Destroy(gameObject);
            cc.enabled = false;
            anim.SetBool("collided_with_star", true);
            GameManager.instance.play.animator.SetBool("has_star", false);
            GameManager.instance.play.has = false;
        }
    }
}
