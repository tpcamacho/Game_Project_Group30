using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5;
    private float dist;
    private float distMin = -5f;
    private float disMax = 5f;
    private Vector3 temp;

    public int EnemyOneLife = 1;
    public int EnemyTwoLife = 1;
    public int BulletDamage = 1;

    public bool goingRight = true;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.002f, transform.position.z);
            speed *= -1;
        }
    }
    
}
