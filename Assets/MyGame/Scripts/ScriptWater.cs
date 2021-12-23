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
        if (other.name == "waterfall")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
            water.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
