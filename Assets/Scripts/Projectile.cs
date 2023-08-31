using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D rigidbody2d;

    public float speed = 20f;

    public float projForce = 800;

    public PlayerController playerCont;

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
        if (other.collider.tag == "Enemy")
        {
            playerCont.score += 100;

            Debug.Log("" + playerCont.score);
        }

        Destroy(gameObject);
    }
}
