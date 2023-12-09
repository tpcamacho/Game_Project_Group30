using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyShoot;
    public float spawnTime;
    public float spawnMax = 10;
    public float spawnMin = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            Instantiate(enemyShoot, transform.position, Quaternion.identity);
            spawnTime = Random.Range(spawnMin, spawnMax);
        }
    }
}
