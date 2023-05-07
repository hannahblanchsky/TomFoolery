using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System;
using UnityEngine;


public class ChestLight : MonoBehaviour
{

    public SerialController serialController;

    public Light myLight;

    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        //myLight = GameObject.Find("Flashlight").GetComponent<Light>(); 
        myLight = GetComponent<Light>();
    }

    //private void Awake()
    // {
    //myLight.Initialize();  // initialize your variables in your component
    // myLight.enabled = false;
    // }

    // Update is called once per frame
    void Update()
    {
        string stateStr = serialController.ReadSerialMessage();
        if (stateStr == null)
        {
            return;
        }
        int state = Int32.Parse(stateStr);
        int high = 1;
        int low = 0;
        //if(Input.GetKeyUp(KeyCode.Space))
        if (state == high)
        {

            myLight.intensity = 2;
            //myLight.enabled = !myLight.enabled;
        }
        else if (state == low)
        {
            myLight.intensity = 0;
        }
    }
}