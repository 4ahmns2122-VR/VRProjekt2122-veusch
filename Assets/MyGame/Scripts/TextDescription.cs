using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading;


public class TextDescription : MonoBehaviour
{


    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;


    private void Start()
    {
        //StartCoroutine(StartWait());

        Invoke("InitialSentence", 3f);

    }

    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(3);
    }


    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


    public void InitialSentence()
    {
        StartCoroutine(Type());
    }
}
