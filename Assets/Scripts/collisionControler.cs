using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionControler : MonoBehaviour
{
    public ballMovement ballmove;
    public scoreController scoreController;
    void BounceOffRacket(Collision2D c)
    {
        Vector3 ballPos = this.transform.position;
        Vector3 racketPos = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;
        //change the ball direction based on which player hit
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
        //increase speed after bounce
        this.ballmove.IncreaseHitCount();
        this.ballmove.MoveBall(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //wall collision, increase speed if hit racket, update score if hit left or right wall
        if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            this.BounceOffRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            this.scoreController.goalPlayer2();
            StartCoroutine(this.ballmove.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            this.scoreController.goalPlayer1();
            StartCoroutine(this.ballmove.StartBall(false));
        }
    }
}
