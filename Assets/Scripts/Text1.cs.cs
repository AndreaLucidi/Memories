using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text1 : MonoBehaviour
{
private bool showText = false;
    void OnTriggerEnter(Collider other)
    {

        showText = true;

    }

void OnGUI () 
{
	if (showText) 
	{

            GUI.Button(new Rect(100, 100, 250, 250), "Press Q");
            if (Input.GetKeyDown(KeyCode.Q))
            {
                showText = false;
            }
            
               
            
			
	}
}
    
}