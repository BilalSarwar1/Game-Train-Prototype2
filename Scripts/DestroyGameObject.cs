using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{

    static int score = 0;
    static int lives = 4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Food")
        {
            score++;
            Destroy(other.gameObject);
            Destroy(gameObject);

            Debug.Log($"Score: {score}");

        }

        if(other.gameObject.tag == "Player")
        {
            lives--;

            if(lives == 1)
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
            Debug.Log($"Lives: {lives-1}");

        }





    }
}
