using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    private float minXBound = -17.4f;
    private float maxXBound = 17.4f;
    private float minYBound = -9.5f;
    private float maxYBound = 9.5f;


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x < minXBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > maxXBound)
        {
            Destroy(gameObject);
        }


        if (transform.position.z < minYBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > maxYBound)
        {
            Destroy(gameObject); ;
        }


    }
}