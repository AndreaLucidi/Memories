using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
public class Return_to_Start : MonoBehaviour {

    public GameObject[] doors;
    public GameObject Player;
    public Quaternion castrRot;
    public Quaternion chstrRot;
    // Use this for initialization
	void Start () {
       doors =  GameObject.FindGameObjectsWithTag("Door");
       Player = GameObject.FindGameObjectWithTag("Player");
       castrRot = Player.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot;
       chstrRot = Player.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot;
        
	}
    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (name == "TP to start 1")
            {
                other.transform.position = new Vector3(28.9f, 0.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
               
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 2")
            {
                other.transform.position = new Vector3(28.9f, 7.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 3")
            {
                other.transform.position = new Vector3(28.9f, 14.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 4")
            {
                other.transform.position = new Vector3(28.9f, 21.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 5")
            {
                other.transform.position = new Vector3(28.9f, 28.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
               other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 6")
            {
                other.transform.position = new Vector3(28.9f, 35.5f, 22.14f);
               other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 7")
            {
                other.transform.position = new Vector3(28.9f, 42.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 8")
            {
                other.transform.position = new Vector3(28.9f, 49.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 9")
            {
                other.transform.position = new Vector3(28.9f, 56.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 10")
            {
                other.transform.position = new Vector3(28.9f, 63.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 11")
            {
                other.transform.position = new Vector3(28.9f, 70.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 12")
            {
                other.transform.position = new Vector3(28.9f, 77.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 13")
            {
                other.transform.position = new Vector3(28.9f, 84.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 14")
            {
                other.transform.position = new Vector3(28.9f, 91.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 15")
            {
                other.transform.position = new Vector3(28.9f, 98.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 16")
            {
                other.transform.position = new Vector3(28.9f, 105.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 17")
            {
                other.transform.position = new Vector3(28.9f, 112.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 18")
            {
                other.transform.position = new Vector3(28.9f, 119.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 19")
            {
                other.transform.position = new Vector3(28.9f, 126.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 20")
            {
                other.transform.position = new Vector3(28.9f, 133.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 21")
            {
                other.transform.position = new Vector3(28.9f, 140.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 22")
            {
                other.transform.position = new Vector3(28.9f, 147.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 23")
            {
                other.transform.position = new Vector3(28.9f, 154.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 24")
            {
                other.transform.position = new Vector3(28.9f, 161.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 25")
            {
                other.transform.position = new Vector3(28.9f, 168.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "TP to start 26")
            {
                other.transform.position = new Vector3(28.9f, 175.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 1")
            {
                other.transform.position = new Vector3(28.9f, 7.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 2")
            {
                other.transform.position = new Vector3(28.9f, 14.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 3")
            {
                other.transform.position = new Vector3(28.9f, 21.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 4")
            {
                other.transform.position = new Vector3(28.9f, 28.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 5")
            {
                other.transform.position = new Vector3(28.9f, 35.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 6")
            {
                other.transform.position = new Vector3(28.9f, 42.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 7")
            {
                other.transform.position = new Vector3(28.9f, 49.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 8")
            {
                other.transform.position = new Vector3(28.9f, 56.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 9")
            {
                other.transform.position = new Vector3(28.9f, 63.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 10")
            {
                other.transform.position = new Vector3(28.9f, 70.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 11")
            {
                other.transform.position = new Vector3(28.9f, 77.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 12")
            {
                other.transform.position = new Vector3(28.9f, 84.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 13")
            {
                other.transform.position = new Vector3(28.9f, 91.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 14")
            {
                other.transform.position = new Vector3(28.9f, 98.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 15")
            {
                other.transform.position = new Vector3(28.9f, 105.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 16")
            {
                other.transform.position = new Vector3(28.9f, 112.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 17")
            {
                other.transform.position = new Vector3(28.9f, 119.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 18")
            {
                other.transform.position = new Vector3(28.9f, 126.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 19")
            {
                other.transform.position = new Vector3(28.9f, 133.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 20")
            {
                other.transform.position = new Vector3(28.9f, 140.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 21")
            {
                other.transform.position = new Vector3(28.9f, 147.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 22")
            {
                other.transform.position = new Vector3(28.9f, 154.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 23")
            {
                other.transform.position = new Vector3(28.9f, 161.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 24")
            {
                other.transform.position = new Vector3(28.9f, 168.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
            if (name == "Go to next 25")
            {
                other.transform.position = new Vector3(28.9f, 175.5f, 22.14f);
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CameraTargetRot = castrRot;
                other.GetComponent<FirstPersonController>().m_MouseLook.m_CharacterTargetRot = chstrRot;
                other.transform.rotation = Quaternion.Euler(0, 180, 0);
                foreach (GameObject drs in doors)
                {
                    drs.GetComponent<Door>().done = false;
                    drs.GetComponent<Door>().interaction = false;

                }
            }
        }
    }
}
