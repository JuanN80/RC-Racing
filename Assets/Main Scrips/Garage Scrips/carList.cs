using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Author: Juan S Neira Galvis
Class Name: carList
Purpose: Stores Car models and allows user to view a car model
*/

public class carList : MonoBehaviour
{

    //Fields for buttons inside Unity
    [SerializeField] Button previousButton;
    [SerializeField] Button nextButton;
    

    //Variable that stores index of the car model

    private int currentCar;
    

    //Loads previously selected car;
    private void Start()
    {
        currentCar = SaveManager.instance.currentCar;
        SelectCar(currentCar);
    }


    //Saves and selects car model
    private void SelectCar(int carNum)
    {
        previousButton.interactable = (carNum != 0);
        nextButton.interactable = (carNum != transform.childCount-1);
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == carNum);
        }



    }

    //Changes car model

    public void ChangeCar(int ch)
    {
        currentCar += ch;
        SaveManager.instance.currentCar = currentCar;
        SaveManager.instance.Save();
        SelectCar(currentCar);


    }
   



}
