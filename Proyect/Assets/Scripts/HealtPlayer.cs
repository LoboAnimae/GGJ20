using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtPlayer : MonoBehaviour
{


    public int playerHealth;
    public bool GameOver;

    // Start is called before the first frame update


    void Start()
    {
        GameOver = false;
    }


    public void Vergazo()
    {
        if (playerHealth == 1)
        {
            PlayHit();
        }
        if(playerHealth == 0)
        {
            PlayDeath();
        }
    }
    void PlayDeath()
    {
        GameOver = true;
        Debug.Log("Death");
    }
    void PlayHit()
    {

    }
}
