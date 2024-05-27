using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
