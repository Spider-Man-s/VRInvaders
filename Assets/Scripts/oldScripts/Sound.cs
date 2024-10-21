using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audio;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audio.isPlaying)
        {
            audio.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && audio.isPlaying)
        {
            audio.Stop();
        }
    }

}

