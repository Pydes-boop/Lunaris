using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceRandom : MonoBehaviour
{

    public AudioSource randomSound;

    public AudioClip[] audioSources;

    // Use this for initialization
    void Start()
    {
        CallAudio();
    }


    void CallAudio()
    {
        Invoke("RandomSoundness", 15);
    }

    void RandomSoundness()
    {
        Debug.Log("It works");
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        if (Random.Range(0, 4) == 1)
        {
            randomSound.Play();
        }
        CallAudio();
    }
}
