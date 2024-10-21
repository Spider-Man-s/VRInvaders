using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource soundToPlay;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (soundToPlay != null && !soundToPlay.isPlaying)
            {
                soundToPlay.Play();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (soundToPlay != null && soundToPlay.isPlaying)
            {
                soundToPlay.Stop();
            }
            
        }
    }

    
}
