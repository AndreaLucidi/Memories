using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {



	// FadeInOut
	#pragma strict;
	var fadeTexture ; Texture2D;
	var fadeSpeed = 0.2;
	var drawDepth = -1000;

	private var alpha = 1.0; 
	private var fadeDir = -1;

	function OnGUI(){

		alpha += fadeDir * fadeSpeed * Time.deltaTime;  
		alpha = Mathf.Clamp01(alpha);   

		GUI.color.a = alpha;

		GUI.depth = drawDepth;

		GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), fadeTexture);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
