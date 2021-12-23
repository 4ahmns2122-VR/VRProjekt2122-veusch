using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSCriptRightHandDoor : MonoBehaviour
{
    


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
        }
    }

    void Update()
    {
        
    }
}
