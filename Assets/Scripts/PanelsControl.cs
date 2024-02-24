using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelsControl : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject difficultyPanel;
    private int difficulty = 0;
    public  int checkdifficulty = 0;

    void Start()
    {
        startPanel.SetActive(true);
    }
    public void Update()
    {
        if(difficulty == 1)
        {
            checkdifficulty = difficulty;
        }
        else if (difficulty == 2)
        {
            checkdifficulty = difficulty;
        }
        else if (difficulty == 3)
        {
            checkdifficulty = difficulty;
        }
    }
    public void ClosePanel()
    {
        startPanel.SetActive(false);
        difficultyPanel.SetActive(true);
    }
    public void EasyTraps()
    {
        difficulty = 1;
    }
    public void MediumTraps()
    {
        difficulty = 2;
    }
    public void DifficultTraps()
    {
        difficulty = 3;
    }
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
