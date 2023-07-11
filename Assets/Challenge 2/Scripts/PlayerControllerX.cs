using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float startDelay = 1f;
    private float spawnIntervel = 1f;
    
    
    private void Start()
    {
        InvokeRepeating("SpawnDog", startDelay, spawnIntervel);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDog();
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

    }
    
}
