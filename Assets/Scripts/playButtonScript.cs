using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButtonScript : MonoBehaviour
{
    public void PlayGame()
    {
        //load the game scene
        SceneManager.LoadScene(1);
    }
}
