using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleEffects : MonoBehaviour
{
    [SerializeField]
    private GameObject center;
    [SerializeField]
    private GameObject player;
    private Rigidbody2D rb;
    private Rigidbody2D rot;
    private Vector2 centerPos;
    public float speed;
    public bool isInside;

    // Start is called before the first frame update
    void Start()
    {
      rb = player.GetComponent<Rigidbody2D>();
      rot = center.GetComponent<Rigidbody2D>();
      centerPos = center.transform.position;
      isInside = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      rot.rotation += 0.5f;
      if(isInside) {
        Vector2 newPos = player.transform.position;
        Vector2 difference = (newPos - centerPos)*-1;
        difference.Normalize();
        rb.velocity =difference*speed*Time.deltaTime;
        Debug.Log(rb.velocity);
      }
    }

    void OnTriggerEnter2D(Collider2D col) {
      if(col.tag=="Player"){
        isInside = true;
        Debug.Log(rb.velocity);
      }
    }

    void OnTriggerExit2D(Collider2D col) {
       if(col.tag=="Player"){
        isInside = false;
       }
    }
}
