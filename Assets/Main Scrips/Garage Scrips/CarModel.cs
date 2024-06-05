using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Author: S Neira Galvis
Class Name: CameraManager
Purpose: Goes through Car models and allows user to select one
*/

public class CarModel : MonoBehaviour
{
    
     [SerializeField] private GameObject [] carModels;

     private void Awake()
     {
        ChooseCarModel(SaveManager.instance.currentCar);


     }

     private void ChooseCarModel(int carNum)
     {

        Instantiate(carModels[carNum], transform.position, Quaternion.identity,transform);


     }
}
