using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return_to_Start : MonoBehaviour {

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
            other.transform.position = Vector3.zero;
            other.transform.rotation = Quaternion.identity;
        }
    }
}
