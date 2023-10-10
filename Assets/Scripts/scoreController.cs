using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class scoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject Player1Score;
    public GameObject Player2Score;

    public int goalToWin;
    
    void Update()
    {
        //check if either player scored enough goals
        if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            Text uiScorePlayer1 = this.Player1Score.GetComponent<Text>();
            Text uiScorePlayer2 = this.Player2Score.GetComponent<Text>();

            uiScorePlayer1.text = this.scorePlayer1.ToString();
            uiScorePlayer2.text = this.scorePlayer2.ToString();
            SceneManager.LoadScene(2);
        }
    }
    private void FixedUpdate()
    {
        //update score everytime either player scores
        Text uiScorePlayer1 = this.Player1Score.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();
        Text uiScorePlayer2 = this.Player2Score.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }
    //incerease playe score
    public void goalPlayer1()
    {
        this.scorePlayer1++;
    }
    public void goalPlayer2()
    {
        this.scorePlayer2++;
    }
}
