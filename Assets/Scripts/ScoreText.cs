using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreText : MonoBehaviour
{
    public PlayerController player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + player.score);
    }
}
