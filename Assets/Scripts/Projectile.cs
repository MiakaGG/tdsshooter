using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D rigidbody2d;
    public float speed = 20;
    public bool collided = false;

    public float projForce = 800;

    public GameObject playerObj;

    public GameObject enemyObj;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 10);
    }
    /*public void Launch(Vector3 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }*/
    public void Launch(Vector3 direction)
    {
        rigidbody2d.AddForce(direction * projForce);
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Proj collided with: " + other.collider.name);
        // IF WE WANT TO ACCESS PLAYER CONTROLLER SCRIPT
        //PlayerController playerC = playerObj.GetComponent<PlayerController>();
        EnemyController enemyC = enemyObj.GetComponent<EnemyController>();
        if (other.collider.tag == "Enemy")
        {
            //add player score here 
            Debug.Log("Proj hit enemy");
        }

        Destroy(gameObject);
    }
}
