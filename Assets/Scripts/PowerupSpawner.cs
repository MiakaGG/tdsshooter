using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject speedPowerupPrefab;

    public GameObject fireRatePowerupPrefab;

    private Vector3 randSpawnLoc;

    public PlayerController playerScoreCont;

    public float powerUpScore;


    void Update()
    {
        Vector3 randSpawnLoc = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);

        if (playerScoreCont.score >= 500);
            {
                
            }
    }
}
