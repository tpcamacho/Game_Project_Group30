using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    public float totalScore;

    public int lives = 3;


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
}
