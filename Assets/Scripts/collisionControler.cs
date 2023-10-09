using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionControler : MonoBehaviour
{
    public ballMovement ballmove;

    void BounceOffRacket(Collision2D c)
    {
        Vector3 ballPos = this.transform.position;
        Vector3 racketPos = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "Player1")
        {
            x = 1;
        }
        else 
        { 
            x = -1; 
        }
        float y = (ballPos.y - racketPos.y) / racketHeight;
        this.ballmove.IncreaseHitCount();
        this.ballmove.MoveBall(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            this.BounceOffRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with left wall");
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with right wall");
        }
    }
}
