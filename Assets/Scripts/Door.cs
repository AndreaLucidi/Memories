using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float smooth = 2.0f;
    private Quaternion targetRotation;
    bool openable;
    bool done;
    new AudioSource audio;
    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        targetRotation = transform.rotation;
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (openable == true)
        {

            if (done == false)
            {

                if (Input.GetKeyDown(KeyCode.E))
                {
                    targetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
                    audio.Play();
                }
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);

            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            openable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            done = true;
            openable = false;
            transform.rotation=Quaternion.identity;
           
        }
    }
}
