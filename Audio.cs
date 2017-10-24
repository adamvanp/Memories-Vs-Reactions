//Adam Van Peelen 2017
//    Used to play audio when needed
//    03/10/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
    public AudioSource playerAudioSource;
    public AudioClip[] voiceAudio;
    // Use this for initialization
    void Start () {
        playerAudioSource.clip = voiceAudio[0];
    }
    public void PlayBlip()
    {
        playerAudioSource.Play();
    }
}
