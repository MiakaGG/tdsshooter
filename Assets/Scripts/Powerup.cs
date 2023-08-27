using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject playerVar;

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
    }
}
