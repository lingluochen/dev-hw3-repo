using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource tuofen;
    void Start()
    {
        Time.timeScale = 0;
        tuofen.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            tuofen.Play();
        }

    }
}
