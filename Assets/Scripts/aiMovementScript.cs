using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiMovementScript : MonoBehaviour
{
    public float speed;
    public GameObject ball;

    private void FixedUpdate()
    {
        //move the player 2 towards the ball
        if(Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if(transform.position.y < ball.transform.position.y)
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * speed;
            else
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
        }
        else
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
