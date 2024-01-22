using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoin : MonoBehaviour
{
    public GameObject coin;
    private float obstacleSpawnTime = 2.0f;
    private float obstacleSpeed = 8.0f;

    private float timeUntilNewObstacle;

    void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        timeUntilNewObstacle += Time.deltaTime;

        if (timeUntilNewObstacle >= obstacleSpawnTime)
        {
            if (Random.Range(0, 5) == 0)
                Spawn();
            timeUntilNewObstacle = 0f;
        }
    }

    private void Spawn()
    {

        float randomY = Random.Range(-4.0f, 4.0f);
        Debug.Log(randomY);

        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);
        GameObject spawnedObstacle = Instantiate(coin, spawnPosition, Quaternion.identity);

        Rigidbody2D rbObstacle = spawnedObstacle.GetComponent<Rigidbody2D>();
        rbObstacle.velocity = Vector3.left * obstacleSpeed;
        rbObstacle.gravityScale = 0;
    }
}
