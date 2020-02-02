using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 movement;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f));
    }

    // Update is called once per frame

    void Update()
    {
      
    }
}
