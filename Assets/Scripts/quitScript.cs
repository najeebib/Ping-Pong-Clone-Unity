using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitScript : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("click");
        Application.Quit();
    }
}
