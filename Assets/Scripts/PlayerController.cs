using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // player movement 
    // player lookAtMouse
    // player shoot?
    // projectile code 
    // instantiate and what not 
    // DONE!!!!

    private Rigidbody2D rb;

    public float moveSpeed;

    // gameObj for projectile prefab
    public GameObject projPrefab;

    public GameObject enemyPrefab;

    public EnemyController enemyS;

    private Vector2 inputMovement;
    private Vector3 dir;
    public Vector2 aimDir;

    public Vector3 playerPos;

    public PlayerData playerData;

    public int score = 0;

    public int gameScore = 0;


    // bool vars to check if player has hit powerup
    public bool playerSpedUp;

    public bool playerFireRateUp;

    // lower = faster for fire rate so 0.1 will shoot really fast
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        EnemyController enemyS = enemyPrefab.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerData.aimDir = aimDir;
        playerData.moveSpeed = moveSpeed;
        playerData.playerPos = playerPos;
        playerData.fireRate = fireRate;
        
        // add timer to shoot statement
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Launch();
        }

        playerPos = rb.position;
    }

    void FixedUpdate()
    {
        // lookToMouse function basically, maybe make it its own function?
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        aimDir = dir.normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Vector2 inputMovement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + inputMovement * Time.fixedDeltaTime * moveSpeed);
    }

    void Launch()
    {
        GameObject projectileObj = Instantiate(projPrefab, transform.GetChild(0).position, transform.GetChild(0).rotation);
        Projectile projectile = projectileObj.GetComponent<Projectile>();

        projectile.Launch(aimDir);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            // Testing for losing health
            Debug.Log("Health - 1");
        }

        if (other.gameObject.tag == "fireRatePowerup")
        {
            fireRate = 0.1f;
            playerFireRateUp = true;
            Debug.Log("MoveSpeed: " + moveSpeed + "fireRate" + fireRate);
        }

        if (other.gameObject.tag == "speedPowerup")
        {
            moveSpeed = 20f;
            playerSpedUp = true;
            Debug.Log("MoveSpeed: " + moveSpeed + "fireRate" + fireRate);
        } 
    }
}
