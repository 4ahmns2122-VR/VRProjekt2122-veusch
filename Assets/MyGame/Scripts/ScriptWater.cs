using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWater : MonoBehaviour
{
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("K�bel ber�hrt wasser"+other.name);
        if (other.name == "WaterFallNew")
        {
          
           // gameObject.GetComponent<SphereCollider>().isTrigger = true;
            water.SetActive(true);
            GameState.instance.StateWaterFilled=true;
           
        }
    }

}
   

