using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{

    // use this class and put it on gameObject to play an audio clip when it is spawned in. 
    // look at start function if you forget how it works and we serialize a _clip var so make sure to put one in

    [SerializeField] private AudioClip _clip;

    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
    }
}