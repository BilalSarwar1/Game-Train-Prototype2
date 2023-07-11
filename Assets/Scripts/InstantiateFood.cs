using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateFood : MonoBehaviour
{
    public GameObject food;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, Quaternion.identity);
        }
    }

    
}
