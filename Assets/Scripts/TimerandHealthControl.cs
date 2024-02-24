using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TİmerandHealthControl : MonoBehaviour
{
    public Text timer;
    private float startTime = 0;
    private bool checktimer = false;
    void Start()
    {
        startTime = Time.time;
        TrapSpawner spawner = FindAnyObjectByType<TrapSpawner>();
        checktimer = spawner.timercheck;
    }


    void Update()
    {
        TrapSpawner spawner = FindAnyObjectByType<TrapSpawner>();
        checktimer = spawner.timercheck;
        if (checktimer == true)
        {
            float elapsedTime = Time.time - startTime;
            string fixedTime = elapsedTime.ToString("F2");
            timer.text = "Timer: " + fixedTime;
        }
    }
}
