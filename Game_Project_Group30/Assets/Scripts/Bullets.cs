using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;

    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DespawnDelay());
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyOne enemyOne = other.GetComponent<EnemyOne>();
        if (enemyOne != null)
        {
            enemyOne.takeDamage(damage);
            Destroy(gameObject);
        }

        EnemyTwo enemyTwo = other.GetComponent<EnemyTwo>();
        if (enemyTwo != null)
        {
            enemyTwo.takeDamage(damage);
            Destroy(gameObject);
        }


    }
        
 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }

    /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy One" || collision.gameObject.tag == "Enemy Two")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    */
}
