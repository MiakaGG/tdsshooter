using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    // when we add a main menu and can have a slider

    [SerializeField] private Slider _slider;
    void Start()
    {
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val));
    }

}
