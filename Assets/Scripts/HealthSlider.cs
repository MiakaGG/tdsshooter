using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public PlayerController player;
    void Start()
    {
       _slider.onValueChanged.AddListener(val => GameManager.Instance.playerLoseHealth(val));
    }
}
