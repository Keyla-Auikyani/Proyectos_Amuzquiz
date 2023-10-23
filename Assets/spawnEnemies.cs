using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 spawnPosition;
    public float spawnRadius;
    public float spawnInterval = 3f;

    void SpawnEnemy()
    {
        float randomY = Random.Range(-spawnRadius, spawnRadius);
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + randomY, transform.position.z);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }
}

