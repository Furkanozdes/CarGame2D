using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTouchControl : MonoBehaviour
{
    public GameObject explosiveAnim;
    private bool isTriggered = false;
    private float delay = 1.0f;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (isTriggered)
        {
          
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                StopGame();
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            isTriggered = true;

            if (isTriggered)
            {
                Instantiate(explosiveAnim, collision.transform.position, Quaternion.identity);

            }
           

        }
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }

}
