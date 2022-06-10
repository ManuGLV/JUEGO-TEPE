using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiAudioSource : MonoBehaviour { 

    public AudioClip SUIsound;
    AudioSource fuenteaudio;

    // Start is called before the first frame update
    void Start()
    {
        fuenteaudio = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fuenteaudio.clip = SUIsound;
            fuenteaudio.Play();
        }
    }
}
