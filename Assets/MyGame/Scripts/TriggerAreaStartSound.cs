using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAreaStartSound : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
            Debug.Log("playing sound");
        }
    }
}
