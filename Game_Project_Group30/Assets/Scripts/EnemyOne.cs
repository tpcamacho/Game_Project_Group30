using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{


    public int enemyOneLife = 1;
    public int bulletDamage = 1;



    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage (int damage)
    {
        enemyOneLife -= damage;
        if (enemyOneLife <= 0)
        {
            Destroy(this.gameObject);
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit Bullet");
            enemyOneLife -= bulletDamage;
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy One")
        {
            enemyOneLife -= bulletDamage;
        }
    }

}
