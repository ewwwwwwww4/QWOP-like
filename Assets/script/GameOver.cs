using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool dead = false;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            text.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space) && dead)
        {
            dead = false;
            text.gameObject.SetActive(false);

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
               
        }
        
}
    // private void OnCollisionEnter2D(Collision2D collision{
    //   if (collision.gameObject.layer == 0) {
    //     dead = true;}}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<floor>())
        {
            dead = true;
        }
    }
}
