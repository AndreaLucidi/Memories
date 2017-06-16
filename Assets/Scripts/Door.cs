using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float smooth = 2.0f;
    private Quaternion targetRotation;
    public bool openable;
    public bool done;
    public AudioSource audio1;
    public AudioSource audio2;
    private bool closed = false;
    private Quaternion startRot;
    public bool interaction;
    // Use this for initialization
    void Start()
    {
        startRot = transform.rotation;
        targetRotation = transform.rotation;
        done = false;
        interaction = false;
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
                    startRot = transform.rotation;

                    targetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
                    audio1.Play();
                     StartCoroutine("stop");
                   closed = true;
                    
                }
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
                if (interaction == true)
                {
                    targetRotation = startRot;
                    openable = false;
                    transform.rotation = startRot;
                    if (closed == true)
                    {
                        audio2.Play();
                        closed = false;
                    }

                }
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
       
    }
    void Wait()
    {
        done = true;
    }
        IEnumerator stop()
        {
            yield return new WaitForSeconds(3f);
        Wait();
        }
    
}
