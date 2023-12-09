using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    public int lives = 3;


    public float totalScore = 0f;

    private float enemyOnePoints = 100f;
    private float enemyTwoPoints = 150f;
    private float bossPoints = 350f;

    public GameObject BulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //returns true for every frame that the player is pressing to the D key
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("THe D key is being pressed");
            //move the object over to the right with Vector3.right by speed (m/s)
            //multiply that by Time.deltaTime to convert m/frame to m/s
            transform.position += Vector3.right * speed * Time.deltaTime;
            Restrictions();
        }

        //returns true for every frame that the player is pressing to the D key
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("THe D key is being pressed");
            //move the object over to the left with Vector3.left by speed (m/s)
            //multiply that by Time.deltaTime to convert m/frame to m/s
            transform.position += Vector3.left * speed * Time.deltaTime;
            Restrictions();
        }

        
    }

    /// <summary>
    /// Prevents bucket from going off screen
    /// </summary>
    private void Restrictions()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.3f, 7.3f), transform.position.y, transform.position.z);
    }

    public void loseLife()
    {
        Debug.Log("Player lost a life");

        lives--;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(2);
        }
           
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy One")
        {
            loseLife();
        }

        if (other.gameObject.tag == "Enemy Two")
        {
            loseLife();
        }

        if (other.gameObject.tag == "Enemy Bullet")
        {
            loseLife();
        }

        

    }


    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy One" || collision.gameObject.tag == "Enemy Two")
        {
            loseLife();
        }

        if (collision.gameObject.tag == "Enemy Bullet")
        {
            loseLife();
        }
    }
    
}
