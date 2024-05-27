using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
  
  //variables used to update the time in Unity 
 [SerializeField] TextMeshProUGUI trackTimeText;
  float elapsedTime;

  //Variables used to store time
  int seconds = 0;
  int minutes = 0;

    void Update()
    { 
     //Gets time between the frames.
        elapsedTime += Time.deltaTime;
    //Divides the time into minutes and seconds
         minutes = Mathf.FloorToInt(elapsedTime / 60);
         seconds = Mathf.FloorToInt(elapsedTime % 60);


   //Convertes the time into text that can be imported into unity.

        trackTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    }


    //Acessor methods that allows us to retrive the min and sec to implement in records.
    int getMin()
    {

        return minutes;
    }

    int getSec()
    {

        return seconds;

    }
}
