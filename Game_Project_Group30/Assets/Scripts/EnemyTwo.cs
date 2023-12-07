using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{

    public int enemyTwoLife = 1;
    public int bulletDamage = 1;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        enemyTwoLife -= damage;
        if (enemyTwoLife <= 0)
        {
            Destroy(this.gameObject);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bulllet")
        {
            enemyTwoLife -= bulletDamage;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy Two")
        {
            enemyTwoLife -= bulletDamage;
        }
    }

}
