using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeManager : MonoBehaviour
{

     //allows rotation
    
    public GameObject toRotate;


    //Allows us to change the speed the car rotates on the podium
    public float rotateSpeed;


    //Rotates Car in Podium
    private void FixedUpdate()
    {
        //it rotates platform & Player
        toRotate.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}