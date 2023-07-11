using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    private float leftBound = -40f;
    private float lowerBound = -10f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        if (gameObject.transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
