using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D rigidbody2d;

    public float speed = 20f;

    public float projForce = 800;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 10);
    }

    public void Launch(Vector3 direction)
    {
        rigidbody2d.AddForce(direction * projForce);
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Proj collided with: " + other.collider.name);
        if (other.collider.tag == "Enemy")
        {
            //add player score here 
            Debug.Log("Proj hit enemy");
        }

        Destroy(gameObject);
    }
}
