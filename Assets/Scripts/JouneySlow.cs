using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class JouneySlow : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<FirstPersonController>().m_WalkSpeed = 1;
            other.GetComponent<FirstPersonController>().m_RunSpeed = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<FirstPersonController>().m_WalkSpeed = 5;
            other.GetComponent<FirstPersonController>().m_RunSpeed = 10;
        }
    }
}
