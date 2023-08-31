using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // move towards player position 
    // if collides with player then player loses health or for now put debug log and enemy is destroyed

    public GameObject playerObj;

    [SerializeField] private AudioClip _clip;

    private Vector3 target;
    private Vector3 position;
    public float enemySpeed = 5.0f; 

    Vector3 velocity;
    private float smoothTime = 0.5f;

    public PlayerData playerData;

    void FixedUpdate()
    {
        position = transform.position;
        target = playerData.playerPos;

        if (target != position)
        {
            float step = enemySpeed * Time.deltaTime;
            transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smoothTime, enemySpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Projectile")
        {
            Destroy(this.gameObject);
            SoundManager.Instance.PlaySound(_clip);
        }
    }
}
