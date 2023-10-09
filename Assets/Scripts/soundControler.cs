using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundControler : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
            this.racketSound.Play();
        else
            this.wallSound.Play();
    }
}
