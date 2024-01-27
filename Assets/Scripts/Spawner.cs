using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private float randomX;
    Vector2 whereToSpawn;
    public float spawnDelay;
    float nextSpawn = 0f;
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            randomX = Random.Range(-1.6f, 1.6f);
            whereToSpawn = new Vector2 (randomX, transform.position.y);
            GameObject Enemy = Instantiate (obj, whereToSpawn, Quaternion.identity);
            Destroy(Enemy, 7f);
        }
    }
}
