using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    private Vector3 spawnLoc = new Vector3(-20f, -13f, 0);
    private Vector3 spawnLoc2 = new Vector3 (20f, -13f, 0f);
    private Vector3 spawnLoc3 = new Vector3(20f, 10f, 0f);
    private Vector3 spawnLoc4 = new Vector3 (-20f, 10f, 0f);    

    // Start is called before the first frame update
    void Start()
    {
        // bottom left spawner
        for(int i = 0; i < 3; i++)
        {
            GameObject enemyObj = Instantiate(enemyPrefab, spawnLoc, transform.rotation);
            EnemyController enemyT = enemyObj.GetComponent<EnemyController>();
        }

        // bottom right spawner
        for(int i = 0; i < 3; i++)
        {
            GameObject enemyObj = Instantiate(enemyPrefab, spawnLoc2, transform.rotation);
            EnemyController enemyT = enemyObj.GetComponent<EnemyController>();
        }
        // top right spawner
        for(int i = 0; i < 3; i++)
        {
            GameObject enemyObj = Instantiate(enemyPrefab, spawnLoc3, transform.rotation);
            EnemyController enemyT = enemyObj.GetComponent<EnemyController>();
        }
        // top left spawner 
        for(int i = 0; i < 3; i++)
        {
            GameObject enemyObj = Instantiate(enemyPrefab, spawnLoc4, transform.rotation);
            EnemyController enemyT = enemyObj.GetComponent<EnemyController>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
