using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float ballSpeed;
    public float speedIncrement;
    public float MaxSpeedIncrement;

    int hitCount = 0;
    void Start()
    {
        StartCoroutine(StartBall());
    }
    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.hitCount = 0;
        yield return new WaitForSeconds(2);
        if(isStartingPlayer1 )
        {
            this.MoveBall(new Vector2(-1,0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    public void MoveBall(Vector2 Dir)
    {
        Dir = Dir.normalized;
        float speed = this.ballSpeed + this.speedIncrement * this.hitCount;

        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Dir * speed;
    }
    public void IncreaseHitCount()
    {
        if (this.hitCount * this.speedIncrement <= this.MaxSpeedIncrement)
            this.hitCount++;
        
    }
}
