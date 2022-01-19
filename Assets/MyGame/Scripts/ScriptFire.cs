using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFire : MonoBehaviour
{
    public GameObject fire;
    public GameObject fire2;
    public GameObject fire3;


    public GameObject waterFilling;


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Kübel berührt feuer" + other.name);

        if (GameState.instance.StateWaterFilled==true)
        {

            if (other.name == "Fire" )
            {
                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire.SetActive(false);
                GameState.instance.fireOut++;
            }

            if (other.name == "Fire2")
            {
                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire2.SetActive(false);
                GameState.instance.fireOut++;
            }

            if (other.name == "Fire3")
            {
                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire3.SetActive(false);
                GameState.instance.fireOut++;
            }


        }

    }
}
