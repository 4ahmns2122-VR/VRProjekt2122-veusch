using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEndDoor : MonoBehaviour
{
   
    void Start()
    {
        transform.position = new Vector3(-8.3f, 0.03f, -2.75f);
    }

    
    void Update()
    {
       
        if (GameState.instance.fireOut==3)
        {
            
            Vector3 newPosition = transform.position; // We store the current position
            newPosition.y = 3; // We set a axis, in this case the y axis
            transform.position = newPosition;
        }
    }
}
