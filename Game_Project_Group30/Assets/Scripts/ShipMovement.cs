using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 5;
    private float dist;
    private float distMin = -5f;
    private float disMax = 5f;
    private Vector3 temp;

    public bool goingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        //Move();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    /*
    private void Move()
    {
        if (goingRight)
        {
            if (transform.position.x >= -dist)
            {
                temp = Vector3.left;
                SetRandomDirectionSwitch();
                goingRight = false;
            }
        }
        else
        {
            if (transform.position.x <= dist)
            {
                temp = Vector3.right;
                SetRandomDirectionSwitch();
                goingRight = true;
            }
        }
        transform.position += temp * Time.deltaTime * speed;
    }


    private void SetRandomDirectionSwitch()
    {
        dist = Random.Range(distMin, disMax);
    }
    */

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.002f, transform.position.z);
            speed *= -1;
        }
    }
    
}
