using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carList : MonoBehaviour
{
    [SerializeField] Button previousButton;
    [SerializeField] Button nextButton;


    private int currentCar;

    private void Start()
    {
        currentCar = SaveManager.instance.currentCar;
        SelectCar(currentCar);
    }

    private void SelectCar(int carNum)
    {
        previousButton.interactable = (carNum != 0);
        nextButton.interactable = (carNum != transform.childCount-1);
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == carNum);
        }



    }

    public void ChangeCar(int ch)
    {
        currentCar += ch;
        SaveManager.instance.currentCar = currentCar;
        SaveManager.instance.Save();
        SelectCar(currentCar);


    }
   



}
