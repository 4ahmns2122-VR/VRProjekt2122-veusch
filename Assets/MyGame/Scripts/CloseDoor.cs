using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject T�rSteht;
    public GameObject T�rDreht;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameState.instance.closeDoor==1)
        {
            T�rSteht.SetActive(true);
            T�rDreht.SetActive(false);
        }
    }
}
