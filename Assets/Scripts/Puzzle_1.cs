using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1 : MonoBehaviour {
    float contatore=Puzzle_1_Real_Solution.contatore;
    // Use this for initialization
    public bool puzzlestart = false;
    bool checkable = false;
    Camera camera1;
    CursorLockMode wantedMode;
	void Start () {
        camera1 = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (puzzlestart == true)
        {

            
            if (Input.GetKeyDown(KeyCode.E))
           {
               
                //Cursor.lockState = wantedMode = CursorLockMode.None;
                Cursor.visible = true;
                
                camera1.enabled = true;
           }
            if (Input.GetKeyDown(KeyCode.F1))
            {
                //Cursor.lockState = wantedMode;
                camera1.enabled = false;
               // Cursor.visible = false;
            }
            if (checkable == false)
            {
                if (Puzzle_1_Real_Solution.contatore == 4)
                {
                    camera1.enabled = false;
                    checkable = true;
                }
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            puzzlestart = true;
           
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puzzlestart = false;
        }
    }
}
