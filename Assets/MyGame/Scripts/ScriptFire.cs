using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFire : MonoBehaviour
{
    public GameObject fire;
    public GameObject waterFilling;


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("K�bel ber�hrt feuer" + other.name);

        if (GameState.instance.StateWaterFilled==true)
        {

            if (other.name == "Fire")
            {

                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire.SetActive(false);


            }
        }

    }
}
