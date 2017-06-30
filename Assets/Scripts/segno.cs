using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segno : MonoBehaviour {

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
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

        }
    }
}
