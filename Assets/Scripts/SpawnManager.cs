using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;

    private float xSpawnPos = 17f;

    private float zSpawnPos = 8f;

    private float delayTime = 1f;
    private float repeatTime = 2f;

    public GameObject player;

    private void Start()
    {
        //InvokeRepeating("SpawnAnimal", delayTime, repeatTime);
        InvokeRepeating("SpawnFromSides", delayTime, repeatTime);
    }


    private void SpawnAnimal()
    {
        {
            var index = Random.Range(0, animals.Length);

            Instantiate(animals[index], new Vector3(Random.Range(-xSpawnPos, xSpawnPos), 0, zSpawnPos),
                animals[index].transform.rotation);
        }
    }

    private void SpawnFromSides()
    {
        var i = Random.Range(0, 2);


        if (i == 0)
        {
            SpawnAnimalFromRight();
        }
        else if (i == 1)
        {
            SpawnAnimalFromLeft();
        }
    }

    private void SpawnAnimalFromRight()
    {
        {
            var index = Random.Range(0, animals.Length);
            Instantiate(animals[index], new Vector3(xSpawnPos, 0, Random.Range(-zSpawnPos, zSpawnPos)),
                Quaternion.LookRotation(Vector3.left));
        }
    }

    private void SpawnAnimalFromLeft()
    {
        {
            var index = Random.Range(0, animals.Length);
            Instantiate(animals[index], new Vector3(-xSpawnPos, 0, Random.Range(-zSpawnPos, zSpawnPos)),
                Quaternion.LookRotation(Vector3.right));
        }
    }
}