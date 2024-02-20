using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TİmerandHealthControl : MonoBehaviour
{
    public Text timer;
    private float startTime = 0;
   
    void Start()
    {
        startTime = Time.time;
    }


    void Update()
    {
        float elapsedTime = Time.time - startTime;
        string fixedTime=elapsedTime.ToString("F2");
        timer.text = "Timer: " + fixedTime;
    }
}
