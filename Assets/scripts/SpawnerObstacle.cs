using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    public GameObject[] obstacles;
    public float obstacleSpawnTime = 4.0f;
    public float obstacleSpeed = 5.0f;

    private float timeUntilNewObstacle;
    void Start()
    {

    }

    void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        timeUntilNewObstacle += Time.deltaTime;

        if (timeUntilNewObstacle >= obstacleSpawnTime)
        {
            Spawn();
            timeUntilNewObstacle = 0f;
        }
    }

    private void Spawn()
    {
        GameObject ObstacleToSpawn = obstacles[Random.Range(0, obstacles.Length)];

        GameObject spawnedObstacle = Instantiate(ObstacleToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D rbObstacle = spawnedObstacle.GetComponent<Rigidbody2D>();
        rbObstacle.velocity = Vector3.left * obstacleSpeed;
    }
}
