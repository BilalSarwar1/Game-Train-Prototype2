using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    static int score = 0;
    static int lives = 4;

    private static int star = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            score++;

            Debug.Log($"Score: {score}");
            if (score % 3 == 0)
            {
                star++;
                Debug.Log($"{star} Stars are active");
            }
            
            Destroy(other.gameObject);
            Destroy(gameObject);

            
        }

        if (other.gameObject.tag == "Player")
        {
            lives--;

            if (lives == 1)
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject);
            Debug.Log($"Lives: {lives - 1}");
        }
    }
}