using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Crouch2 : MonoBehaviour {
    public float c_walk = 3;
    public float c_run = 4;
    public float n_walk = 5;
    public float n_run = 10;
	// Use this for initialization
	void Start () {
        GetComponent<FirstPersonController>().m_WalkSpeed = n_walk;
        GetComponent<FirstPersonController>().m_RunSpeed = n_run;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<FirstPersonController>().m_WalkSpeed = c_walk;
            GetComponent<FirstPersonController>().m_RunSpeed = c_run;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            GetComponent<FirstPersonController>().m_WalkSpeed = n_walk;
            GetComponent<FirstPersonController>().m_RunSpeed = n_run;
        }
    }

}
