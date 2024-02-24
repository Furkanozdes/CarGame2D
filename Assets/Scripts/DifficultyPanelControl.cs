using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyPanelControl : MonoBehaviour
{
    public int difficulty = 0;
    private int checkdifficulty;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (checkdifficulty == 1) {
            difficulty = 1;
        }
        else if (checkdifficulty == 2)
        {
            difficulty = 2;
        }
        else if (checkdifficulty == 3)
        {
            difficulty = 3;
        }
    }
    public void EasyTraps()
    {
        checkdifficulty = 1;
        SceneManager.LoadScene("GameScene");
    }
    public void MediumTraps()
    {
        checkdifficulty = 2;
        SceneManager.LoadScene("GameScene");
    }
    public void DifficultTraps()
    {
        checkdifficulty = 3;
        SceneManager.LoadScene("GameScene");
    }
}
