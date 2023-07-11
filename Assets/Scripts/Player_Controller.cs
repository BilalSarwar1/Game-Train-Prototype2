using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private float HorizontalAxes;
    private float VerticalAxes;

    public float speed;

    private float minXBound = -17.4f;
    private float maxXBound = 17.4f;
    private float minYBound = -9.5f;
    private float maxYBound = 9.5f;

    // Update is called once per frame
    void Update()
    {
        HorizontalAxes = Input.GetAxis("Horizontal");
        VerticalAxes = Input.GetAxis("Vertical");

        transform.Translate(HorizontalAxes * Time.deltaTime * speed, 0, VerticalAxes * Time.deltaTime * speed);

        if (transform.position.x < minXBound)
        {
            transform.position = new Vector3 ( minXBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > maxXBound)
        {
            transform.position = new Vector3(maxXBound, transform.position.y, transform.position.z); ;
        }


        if (transform.position.z < minYBound)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, minYBound);
        }
        else if (transform.position.z > maxYBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxYBound); ;
        }




    }
}