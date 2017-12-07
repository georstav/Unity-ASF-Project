using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour {

    
    public AudioSource AudioSource;
    public AudioClip AudioClip;

    public bool PlayOnAwake;

    void Awake()
    {
        AudioSource.clip = AudioClip;

        if (PlayOnAwake)
            Play();
    }

    public void Play()
    {
        if (!AudioSource.isPlaying)
            AudioSource.Play();
    }

    public void Stop()
    {
        AudioSource.Stop();
    }

    public void Pause()
    {
        AudioSource.Pause();
    }

    public void UnPause()
    {
        AudioSource.UnPause();
    }
}
