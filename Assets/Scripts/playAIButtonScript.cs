using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAIButtonScript : MonoBehaviour
{
    public void PlayGame()
    {
        //load the game against ai scene
        SceneManager.LoadScene(3);
    }
}
