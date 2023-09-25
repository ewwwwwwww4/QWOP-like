using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl1 : MonoBehaviour
{
    public GameObject deathText;
    public GameObject winText;

    private bool isDead = false;
    private bool hasWon = false;

    void Update()
    {
        if (isDead)
        {
            deathText.SetActive(true);
            winText.SetActive(false);
        }
        else if (hasWon)
        {
            winText.SetActive(true);
            deathText.SetActive(false);
        }
        else
        {
            winText.SetActive(false);
            deathText.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isDead || hasWon)
            {
                RestartLevel();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<floor>())
        {
            isDead = true;
        }
        else if (collision.GetComponent<custom>())
        {
            hasWon = true;
        }
    }

    private void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
