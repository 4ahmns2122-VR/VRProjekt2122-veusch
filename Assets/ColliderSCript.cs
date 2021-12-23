using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSCript : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision "+other.name);
        if (other.name == "01_low")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
            Debug.Log("trigger geht");
        }
    }

    
}
