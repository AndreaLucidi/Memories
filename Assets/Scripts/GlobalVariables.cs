using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class GlobalVariables : MonoBehaviour {
    public GameObject Player;
    public Quaternion castrRot;
    public Quaternion chstrRot;
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        castrRot = Player.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot;
        chstrRot = Player.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
