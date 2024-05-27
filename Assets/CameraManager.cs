using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraManager : MonoBehaviour
{

/*
Author: Juan S Neira Galvis
Class Name: CameraManager
Purpose: Class used to control when the car camara gets turned on.
*/

//Gets variables from Unity
    [SerializeField] GameObject camera1; 
    [SerializeField] bool onOff;

    void Awake()
    {

//Sets camera on or off 
    if(onOff == true)
        {
            camera1.SetActive(true);
        }

        else
        {

            camera1.SetActive(false);
        }

       
       

    }


    
}
