using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Vel_Met : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f));
        rb.rotation = 45.0f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.rotation = rb.rotation + 0.1f;
    }
}
