using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public float speed = 10;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        float xAx = Input.GetAxis("Horizontal");
        float yAx = Input.GetAxis("Vertical");   
        Vector3 pos = new Vector3(xAx, 0, yAx);
        transform.position += pos * Time.deltaTime * speed;
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0.8F, 0);
        }
        
  }
}
