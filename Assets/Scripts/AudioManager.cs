using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    public AudioSource audioSource;
    public AudioClip flapAudio;
    public AudioClip endGameAudio;
    public AudioClip scoreAudio;

    private void Start()
    {
        Instance = this;
    }

    public void PlayFlapBirdAudio()
    {
        audioSource.PlayOneShot(flapAudio);
    }

    public void PlayEndGameAudio()
    {
        audioSource.PlayOneShot(endGameAudio);
    }
    public void PlayScoreAudio()
    {
        audioSource.PlayOneShot(scoreAudio);
    }
    /*public void PauseAudio()
    {
       sẽ làm sau 
    }*/
}
