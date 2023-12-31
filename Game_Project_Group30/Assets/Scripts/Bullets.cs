using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private ScoreManager scoreManager;
    public float speed;

    public int damage = 1;

    public float totalScore = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DespawnDelay());
        scoreManager = GameObject.Find("Points").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyOne enemyOne = other.GetComponent<EnemyOne>();
        if (enemyOne != null)
        {
            enemyOne.takeDamage(damage);
            scoreManager.updateScore(93);
            Destroy(gameObject);
        }

        EnemyTwo enemyTwo = other.GetComponent<EnemyTwo>();
        if (enemyTwo != null)
        {
            enemyTwo.takeDamage(damage);
            scoreManager.updateScore(156);
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
