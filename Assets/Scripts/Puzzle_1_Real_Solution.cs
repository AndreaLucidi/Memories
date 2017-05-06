using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1_Real_Solution : MonoBehaviour {
    public GameObject visible;
    public static float contatore = 0;
    public BoxCollider box;
	// Use this for initialization
	void Start () {
        box.enabled = true;
        visible.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            visible.SetActive(true);
            contatore += 1;
            //Debug.Log(contatore);
            box.enabled = false;

        }
    }
}
