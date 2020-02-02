using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_3 : MonoBehaviour
{
    private Rigidbody2D rb;
    public int simbolo;
    public int simbolo2;
    // Start is called before the first frame update

    void Start()
    {
        if (Random.Range(-1f, 1f) > 0 || Random.Range(-1f, 1f) == 0)
        {
            simbolo = 1;
        }
        else
        {
            simbolo = -1;
        }

        if (Random.Range(-1f, 1f) > 0 || Random.Range(-1f, 1f) == 0)
        {
            simbolo2 = 1;
        }
        else
        {
            simbolo2 = -1;
        }

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(simbolo * 15, simbolo2 * 15);
    }

    // Update is called once per frame

    void Update()
    {

    }
}
