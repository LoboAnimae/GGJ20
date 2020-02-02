using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public player user;
    public bool isFollowing;
    public float wOffset;

    // Start is called before the first frame update
    void Start()
    {
     user = FindObjectOfType<player>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(user.transform.position.x, user.transform.position.y, -10f);
    }
}
