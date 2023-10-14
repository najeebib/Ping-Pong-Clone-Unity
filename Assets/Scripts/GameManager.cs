using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Game pause elements")]
    public GameObject gamePausePanel;
    // Start is called before the first frame update
    void Awake()
    {
        gamePausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)) 
        {
            gamePausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
    }
}
