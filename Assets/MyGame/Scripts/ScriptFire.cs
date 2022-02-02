using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFire : MonoBehaviour
{

    public GameObject fire;
    public GameObject fire2;
    public GameObject fire3;

    public GameObject fireDistortion;
    public GameObject fireDistortion2;
    public GameObject fireDistortion3;

    public GameObject smoke;
    public GameObject smoke2;
    public GameObject smoke3;

    public int fireExtuinguished;

    public GameObject waterFilling;
    public GameObject waterFillingStufe2;
    public GameObject waterFillingStufe3;




    private void Start()
    {
        smoke.SetActive(false);
        smoke2.SetActive(false);
        smoke3.SetActive(false);


    }

    private void Update()
    {
        if(fireExtuinguished==1)
        {
            waterFilling.SetActive(false);
        }

        if (fireExtuinguished == 2)
        {
            waterFillingStufe2.SetActive(false);
        }

        if (fireExtuinguished == 3)
        {
            waterFillingStufe3.SetActive(false);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        

        if (GameState.instance.StateWaterFilled==true)
        {

            if (other.name == "Fire" )
            {
                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire.SetActive(false);
                fireDistortion.SetActive(false);
                smoke.SetActive(true);
                GameState.instance.fireOut++;
                GameState.instance.fire1Out++;
                fireExtuinguished++;
            }

            if (other.name == "Fire2")
            {
                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire2.SetActive(false);
                fireDistortion2.SetActive(false);
                smoke2.SetActive(true);
                GameState.instance.fire2Out++;

                fireExtuinguished++;
                GameState.instance.fireOut++;
            }

            if (other.name == "Fire3")
            {
                // gameObject.GetComponent<SphereCollider>().isTrigger = true;
                fire3.SetActive(false);
                fireDistortion3.SetActive(false);
                smoke3.SetActive(true);
                GameState.instance.fire3Out++;
                fireExtuinguished++;
                GameState.instance.fireOut++;
            }


        }

    }

}
