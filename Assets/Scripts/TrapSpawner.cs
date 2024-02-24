using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;


public class TrapSpawner : MonoBehaviour
{
    private int difficulty = 0;
    private bool checktrigger;
    float timer = 0;
    public GameObject trap;
    int index = 0;
    GameObject go;
    public GameObject spawnTraps;
    int[] TrapsDifficult = new int[]
        { 1, 3, 2, 3, 1, 2, 1, 2, 1, 3, 2, 1, 2, 1, 2, 3, 2, 1, 2, 3, 1, 2, 3, 3, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3, 
          2, 1, 2, 3, 1, 3, 3, 1, 3, 1, 2, 3, 3, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1, 3, 1, 2, 2, 3, 1, 1, 2, 3, 3, 1, 3, 3, 2, 
          1, 1, 3, 2, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3, 2, 1, 2, 2, 1, 3, 2, 1, 1, 3, 1, 2, 3, 3, 2, 1, 3, 1, 3, 1};
    int[] TrapsEasy = new int[]
        {2, 1, 3, 2, 1, 3, 3, 1, 2, 1, 2, 3, 1, 2, 1, 2, 3, 2, 1, 2, 3, 1, 2, 3, 3, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3,
         2, 1, 2, 3, 1};
    int[] TrapsMedium = new int[]
        {2, 1, 3, 2, 1, 3, 3, 1, 2, 1, 2, 3, 1, 2, 1, 2, 3, 2, 1, 2, 3, 1, 2, 3, 3, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3,
         2, 1, 2, 3, 1, 3, 3, 1, 3, 1, 2, 3, 3, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1};



    void Start()
    {
        TrapTouchControl TrapTouchControl = FindObjectOfType<TrapTouchControl>();
        checktrigger = TrapTouchControl.isTriggered;
        DifficultyPanelControl DifficultyPanelControl = FindObjectOfType<DifficultyPanelControl>();
        if (DifficultyPanelControl != null)
        {
            difficulty = DifficultyPanelControl.difficulty;
        }
        else
        {
            Debug.Log(difficulty);
        }
        //Invoke("TrapsSpawner",1f);
    }

    void Update()
    {
        timer += Time.deltaTime;
        TrapTouchControl TrapTouchControl = FindObjectOfType<TrapTouchControl>();
        checktrigger = TrapTouchControl.isTriggered;
        DifficultyPanelControl DifficultyPanelControl = FindObjectOfType<DifficultyPanelControl>();
        if (DifficultyPanelControl != null)
        {
            difficulty = DifficultyPanelControl.difficulty;
        }
        else
        {
            Debug.Log(difficulty);
        }
        if (timer > 0.75f && checktrigger == false && difficulty == 3)
        {
            TrapsSpawner();
            timer = 0;
            index++; 
        }
        else if (timer > 0.75f && checktrigger == false && difficulty == 2)
        {
            TrapsSpawnerMiddle();
            timer = 0;
            index++;
        }
        else if (timer > 0.75f && checktrigger == false && difficulty == 1)
        {
            TrapsSpawnerEasy();
            timer = 0;
            index++;
        }

    }
    
    void TrapsSpawner() {
            if(index<100){

            if (TrapsDifficult[index] == 1) // left
            {
                go = Instantiate(trap, new Vector3(-4.5f,8,0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
            else if (TrapsDifficult[index] == 2) // middle
            {
                go = Instantiate(trap, new Vector3(0, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
            else if (TrapsDifficult[index] == 3) //right
            {
                go = Instantiate(trap, new Vector3(5, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
        }
    }
    void TrapsSpawnerMiddle()
    {
        if (index < 61)
        {

            if (TrapsDifficult[index] == 1) // left
            {
                go = Instantiate(trap, new Vector3(-4.5f, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
            else if (TrapsDifficult[index] == 2) // middle
            {
                go = Instantiate(trap, new Vector3(0, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
            else if (TrapsDifficult[index] == 3) //right
            {
                go = Instantiate(trap, new Vector3(5, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
        }
    }
    void TrapsSpawnerEasy()
    {
        if (index < 41)
        {

            if (TrapsDifficult[index] == 1) // left
            {
                go = Instantiate(trap, new Vector3(-4.5f, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
            else if (TrapsDifficult[index] == 2) // middle
            {
                go = Instantiate(trap, new Vector3(0, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
            else if (TrapsDifficult[index] == 3) //right
            {
                go = Instantiate(trap, new Vector3(5, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsDifficult, 0, 1);
            }
        }
    }
}
