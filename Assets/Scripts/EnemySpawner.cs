using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;

    public PlayerController player;
    private Vector3 spawnLoc = new Vector3(-20f, -13f, 0);
    private Vector3 spawnLoc2 = new Vector3 (20f, -13f, 0f);
    private Vector3 spawnLoc3 = new Vector3(20f, 10f, 0f);
    private Vector3 spawnLoc4 = new Vector3 (-20f, 10f, 0f);    

    public float enemyTimer = 2.0f;

    public float nextSpawn = 0.0f;

    void Update()
    {
        Vector3 randSpawnLoc = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);

        if (Time.time > nextSpawn && randSpawnLoc != player.playerPos)
        {
            nextSpawn = Time.time + enemyTimer;
            GameObject enemyObj = Instantiate(enemyPrefab, randSpawnLoc, transform.rotation);
            EnemyController enemyT = enemyObj.GetComponent<EnemyController>();
        }

        if (nextSpawn > 20f)
        {
            enemyTimer = 1f;
        }

        if (nextSpawn > 35f)
        {
            enemyTimer = 0.5f;
        }
    }
}
