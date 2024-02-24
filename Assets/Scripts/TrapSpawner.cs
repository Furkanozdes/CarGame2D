using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;


public class TrapSpawner : MonoBehaviour
{
    public GameObject difficultyPanel;
    private int difficulty = 0;
    private bool checktrigger;
    float timer = 0;
    public GameObject trap;
    int index = 0;
    GameObject go;
    public GameObject spawnTraps;
    public bool timercheck = false;

    int[] TrapsDifficult = new int[]
        { 1, 3, 2, 3, 1, 2, 1, 2, 1, 3, 2, 1, 2, 1, 2, 3, 2, 1, 2, 3, 1, 2, 3, 3, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3, 
          2, 1, 2, 3, 1, 3, 3, 1, 3, 1, 2, 3, 3, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1, 3, 1, 2, 2, 3, 1, 1, 2, 3, 3, 1, 3, 3, 2, 
          1, 1, 3, 2, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3, 2, 1, 2, 2, 1, 3, 2, 1, 1, 3, 1, 2, 3, 3, 2, 1, 3, 1, 3, 1};
    int[] TrapsEasy = new int[]
        {2, 1, 2, 3, 1, 3, 3, 1, 3, 1, 2, 3, 3, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1, 3, 1, 2, 2, 3, 1, 1, 2, 3, 3, 1, 3, 3, 2,1,1};
    int[] TrapsMedium = new int[]
        {2, 1, 3, 2, 1, 3, 3, 1, 2, 1, 2, 3, 1, 2, 1, 2, 3, 2, 1, 2, 3, 1, 2, 3, 3, 1, 2, 2, 3, 3, 1, 3, 2, 1, 3,
         2, 1, 2, 3, 1, 3, 3, 1, 3, 1, 2, 3, 3, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1};



    void Start()
    {
        TrapTouchControl TrapTouchControl = FindObjectOfType<TrapTouchControl>();
        checktrigger = TrapTouchControl.isTriggered;
        difficultyPanel.SetActive(true);
        //Invoke("TrapsSpawner",1f);
    }

    void Update()
    {
        timer += Time.deltaTime;
        TrapTouchControl TrapTouchControl = FindObjectOfType<TrapTouchControl>();
        checktrigger = TrapTouchControl.isTriggered;
        if (difficulty == 3)
        {
            if (timer > 0.75f && checktrigger == false)
            {
                TrapsSpawner();
                timer = 0;
                index++;
            }
        }
        else if (difficulty == 2)
        {
            if (timer > 0.75f && checktrigger == false)
            {
                TrapsSpawnerMiddle();
                timer = 0;
                index++;
            }
        }
        else if (difficulty == 1)
        {
            if (timer > 0.75f && checktrigger == false)
            {
                TrapsSpawnerEasy();
                timer = 0;
                index++;
            }
        }

    }
    public void EasyCheck()
    {
        difficulty = 1;
        difficultyPanel.SetActive (false);
        timercheck = true;
    }
    public void MiddleCheck()
    {
        difficulty = 2;
        difficultyPanel.SetActive(false);
        timercheck = true;
    }
    public void DifficultCheck()
    {
        difficulty = 3;
        difficultyPanel.SetActive(false);
        timercheck = true;
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
        if (index < 65)
        {

            if (TrapsMedium[index] == 1) // left
            {
                go = Instantiate(trap, new Vector3(-4.5f, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsMedium, 0, 1);
            }
            else if (TrapsMedium[index] == 2) // middle
            {
                go = Instantiate(trap, new Vector3(0, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsMedium, 0, 1);
            }
            else if (TrapsMedium[index] == 3) //right
            {
                go = Instantiate(trap, new Vector3(5, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsMedium, 0, 1);
            }
        }
    }
    void TrapsSpawnerEasy()
    {
        if (index < 45)
        {

            if (TrapsEasy[index] == 1) // left
            {
                go = Instantiate(trap, new Vector3(-4.5f, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsEasy, 0, 1);
            }
            else if (TrapsEasy[index] == 2) // middle
            {
                go = Instantiate(trap, new Vector3(0, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsEasy, 0, 1);
            }
            else if (TrapsEasy[index] == 3) //right
            {
                go = Instantiate(trap, new Vector3(5, 8, 0), Quaternion.identity, spawnTraps.transform) as GameObject;
                Array.Clear(TrapsEasy, 0, 1);
            }
        }
    }
}
