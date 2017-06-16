using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextTrigger : MonoBehaviour
{
    private bool showText = false;
    public GameObject Testo;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    
    void OnTriggerEnter(Collider other)
    {

        showText = true;

    }

    void Update ()
    {
        if (showText)
        {

            Testo.SetActive(true);
            Testo.GetComponentInChildren<Text>().text = "1970. I was only 18 when I was sent to Vietnam. I remembered my mother’s tears rolling down her face, begging me to stay one more year; my dad, that bastard, he didn’t even came to say goodbye...I bet he was drunk.";
            if (Input.GetKeyDown(KeyCode.Q))
            {
                showText = false;
                Testo.SetActive(false);
            }




        }

    }
}