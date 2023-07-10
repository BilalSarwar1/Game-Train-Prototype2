using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateFood : MonoBehaviour
{
    public GameObject food;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
        }
    }
}
