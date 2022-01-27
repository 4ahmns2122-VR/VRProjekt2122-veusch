using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "01_low")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
            Debug.Log("trigger geht");
            audioSource.Play();
        }
    }
}
