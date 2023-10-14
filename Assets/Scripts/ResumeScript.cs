using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeScript : MonoBehaviour
{
    public GameObject gamePausePanel;
    public void ResumeGame()
    {
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
    }
}
