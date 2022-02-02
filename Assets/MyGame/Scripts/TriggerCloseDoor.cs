using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCloseDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bucket")
        {
            GameState.instance.closeDoor=1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
