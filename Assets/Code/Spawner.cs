using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;

    public Transform BorderRight;
    public Transform BorderLeft;

    public float SpawnInterval;
    public float SpawnTimer;

    private void Update()
    {
        SpawnTimer -= Time.deltaTime;
        if (SpawnTimer <= 0)
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        float randomX = Random.Range(BorderLeft.position.x, BorderRight.position.x);
        Vector2 newPosition = transform.position;
        newPosition.x = randomX;

        Instantiate(Prefab, newPosition, Quaternion.identity);
        SpawnTimer = SpawnInterval;
    }
 }
