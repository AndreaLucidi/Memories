using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioFinale : MonoBehaviour
{

    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Actual Level")
        {
            Destroy(this.gameObject);
        }
    }
}