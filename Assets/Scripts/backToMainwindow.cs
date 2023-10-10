using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMainwindow : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        //load the main menus
        SceneManager.LoadScene(0);
    }
}
