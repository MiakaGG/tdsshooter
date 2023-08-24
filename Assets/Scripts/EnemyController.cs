using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // move towards player position 
    // if collides with player then player loses health or for now put debug log and enemy is destroyed

    public GameObject playerCont;

    private Vector3 target;
    private Vector3 position;
    private float speed = 5f; 

    Vector3 velocity;
    private float smoothTime = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = transform.position;
        PlayerController playerC = playerCont.GetComponent<PlayerController>();
        target = playerC.playerPos;

        if (target != position)
        {
            float step = speed * Time.deltaTime;
            //transform.position = Vector2.MoveTowards(transform.position, target, step);
            transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smoothTime, speed);
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
