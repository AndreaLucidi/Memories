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
            if (name == "Start Text")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "1970. I was only 18 when I was sent to Vietnam. I remembered my mother’s tears rolling down her face, begging me to stay one more year; my dad, that bastard, he didn’t even came to say goodbye...I bet he was drunk.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
        if (name == "Special Text 1")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "One day we’ve been kidnapped by some viet congs and I was scared as a fuck about our lives; luckily they didn’t tortured me and Billy, but some soldiers of our army were brutally killed.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Special Text 2")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "We went to our camp and, of course, they burned it down. From those ashes we build a new one in less than a week; we took this short time because most of us were already killed: from 100 soldiers, we were remained only 30.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Special Text 3")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Days never passed and we became even more neurotic: I hadn’t slept for weeks and I lost a lot of weight, every single noise makes me wanna turn around to see if there’s some psycho Viet cong following me.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Special Text 4")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Billy stood up and went closer to the water “I wasn’t ready for this” he said “what are you talking about ?” I asked very warned “I’m not ready for this” he started to sticking out “What the fuck are you doing ??” I screamed “I’m saving my life, Mikey” he whispered “goodbye my friend”";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }





        }

    }
}