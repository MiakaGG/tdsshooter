using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject playerVar;

    public EnemyData enemyData;

    void Start()
    {
        PlayerController playerC = playerVar.GetComponent<PlayerController>();

    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }   

        if (other.gameObject.tag == "Enemy")
        {
            enemyData.enemySpeed = 0.1f;
        }
    }
}
