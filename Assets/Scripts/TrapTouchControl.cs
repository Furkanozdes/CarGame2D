using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapTouchControl : MonoBehaviour
{
    public GameObject explosiveAnim;
    public AudioClip explosionSound;
    public GameObject FinishPanel;
    public bool isTriggered = false;
    private bool hasPlayed = false;

    void Update()
    {
        if (isTriggered && !hasPlayed)
        {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            hasPlayed = true;
            StartCoroutine(StopGameAfterDelay());
        }
    }

    IEnumerator StopGameAfterDelay()
    {
        yield return new WaitForSeconds(1.0f);
        StopGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            isTriggered = true;
            Instantiate(explosiveAnim, collision.transform.position, Quaternion.identity);
        }
    }

    void StopGame()
    {
        FinishPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
