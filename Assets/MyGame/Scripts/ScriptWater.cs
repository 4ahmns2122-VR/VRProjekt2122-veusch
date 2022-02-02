using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWater : MonoBehaviour
{
    public GameObject water;
    public GameObject water2;
    public GameObject water3;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Kübel berührt wasser"+other.name);
        if (other.name == "WaterFallNew")
        {
          
           // gameObject.GetComponent<SphereCollider>().isTrigger = true;
            water.SetActive(true);
            water2.SetActive(true);
            water3.SetActive(true);
            GameState.instance.StateWaterFilled=true;
           
        }
    }

}
   

