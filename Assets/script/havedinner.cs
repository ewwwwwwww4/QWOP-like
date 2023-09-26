using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class havedinner : MonoBehaviour
{
    public class HaveDinner : MonoBehaviour
    {
        private bool haveDinner = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Overlapped with " + collision.gameObject.name);

            if (collision.gameObject.name == "custom")
            {
                haveDinner = true;
                Destroy(collision.gameObject);

                PlayerPrefs.SetInt("DinnerDestroyed", 1);
            }
        }
    }
}