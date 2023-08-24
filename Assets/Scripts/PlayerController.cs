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

    public float moveSpeed = 20.0f;

    // gameObj for projectile prefab
    public GameObject projPrefab;

    private Vector2 inputMovement;
    private Vector3 dir;
    public Vector2 aimDir;

    public Vector3 playerPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Launch();
        }

        playerPos = rb.position;

        //Debug.Log("" + aimDir);
    }

    void FixedUpdate()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        aimDir = dir.normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Vector2 inputMovement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //curVel = inputMovement * moveSpeed;
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
    }
}
