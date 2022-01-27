using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSCriptRightHandDoor : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;


    void Start()
    {

       
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision "+other.name);
        if (other.name == "01_low")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
            Debug.Log("trigger geht");
            audioSource.Play();
        }

        if (other.name == "SM_Wooden_Bucket")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
            Debug.Log("trigger geht");
            audioSource2.Play();
        }


    }

    void Update()
    {
        
    }
}
