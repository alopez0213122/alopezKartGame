using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cam : MonoBehaviour
{
    public GameObject frontCam;
    public GameObject backCam;
    public bool front = true;
    // Start is called before the first frame update
    void Start()
    {
        backCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (front == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                frontCam.SetActive(false);
                backCam.SetActive(true);
                front = false;
            }
        }
        if (front == false)
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                backCam.SetActive(false);
                frontCam.SetActive(true);
                front = true;
            }
        }
    }
}
