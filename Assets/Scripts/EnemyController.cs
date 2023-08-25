using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // move towards player position 
    // if collides with player then player loses health or for now put debug log and enemy is destroyed

    public GameObject playerObj;

    public EnemyData enemyData;

    private Vector3 target;
    private Vector3 position;
    public float enemySpeed = 5.0f; 

    Vector3 velocity;
    private float smoothTime = 0.5f;

    public PlayerData playerData;


    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        enemyData.enemySpeed = enemySpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = transform.position;
        PlayerController playerC = playerObj.GetComponent<PlayerController>();
        target = playerData.playerPos;

        if (target != position)
        {
            float step = enemySpeed * Time.deltaTime;
            //transform.position = Vector2.MoveTowards(transform.position, target, step);
            transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smoothTime, enemySpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit Player!");
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Projectile")
        {
            Destroy(this.gameObject);
        }
    }
}
