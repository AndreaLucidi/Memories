using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        GUI.Label(new Rect((Screen.width) / 2 - (Screen.width) / 8, (Screen.height) / 2 - (Screen.height) / 8, (Screen.width) / 2, (Screen.height) / 2), ("I Fantastici 4 \r\n Lorenza Balduini \r\n Giampaolo Piccini \r\n Roberta Capitani \r\n Andrea Lucidi"));  
    }
}
