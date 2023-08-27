using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "topdownshooter/PlayerData", order = 0)]
public class PlayerData : ScriptableObject {
    
    public Vector2 aimDir;
    public float moveSpeed;
    public Vector3 playerPos;
    public float fireRate;

    public float score;

}
