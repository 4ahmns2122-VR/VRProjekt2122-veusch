using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject TürSteht;
    public GameObject TürDreht;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameState.instance.closeDoor==1)
        {
            TürSteht.SetActive(true);
            TürDreht.SetActive(false);
        }
    }
}
