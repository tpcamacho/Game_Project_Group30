using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float score;
    public float speed = 5f;
    public TMP_Text scoreText;

    public BossMovement Boss;
    Vector3 temporary = new Vector3(0f, 5f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 1245)
        {

            return;
        }

        transform.Translate(Vector3.right * speed * Time.deltaTime);


        if (score >= 1245)
        {
            return;
        }
        //  transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (score >= 1245)
        {
            // transform.position = transform.position.tag("bossSpawn");
            //0f, 5f, 0f
            //Vector3 temp = new Vector3(7.0f,0,0);
            //myGameObject.transform.position += temp;
            Boss.transform.position = temporary;
        }
    }


    public void updateScore(float points)
    {
        score += points;
        scoreText.text = "Score: " + score;
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
