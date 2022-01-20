using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{


    public static GameState instance;

    public bool StateWaterFilled=false;

    public int fireOut;
    public int fire1Out;
    public int fire2Out;
    public int fire3Out;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
    }


}
