using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject speedPowerupPrefab;

    public GameObject fireRatePowerupPrefab;

    private Vector3 randPowerSpawnLoc;

    public float randSpawnChance;

    private float randPowerSpawnTimer;

    public PlayerController playerScoreCont;

    void Update()
    {
        Vector3 randPowerSpawnLoc = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);

        float randSpawnChance = Random.Range(0.0f, 1.0f);

        if (playerScoreCont.score >= 800 && randSpawnChance < 0.5f)
        {
            GameObject speedPowerupObj = Instantiate(speedPowerupPrefab, randPowerSpawnLoc, transform.rotation);
            Powerup powerupT = speedPowerupObj.GetComponent<Powerup>();
            playerScoreCont.score -= 800;
        }
        if(playerScoreCont.score >= 800 && randSpawnChance > 0.5f)
        {
            GameObject fireRatePowerupObj = Instantiate(fireRatePowerupPrefab, randPowerSpawnLoc, transform.rotation);
            Powerup powerupF = fireRatePowerupObj.GetComponent<Powerup>();
            playerScoreCont.score -= 800;
        }
    }
}
