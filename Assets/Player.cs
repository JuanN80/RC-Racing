using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    
    public float BestLapTime {get; private set;} = Mathf.Infinity;
    public float LastLapTime { get; private set;} = 0;
    public float CurrentLapTime { get; private set;} = 0;
    public int CurrentLap {get; private set;} = 0;
    
    private float lapTimerTimestamp;
    private int lastCheckpointPassed = 0;
    private Transform checkpointsParent;
    private int checkpointCount;
    private int checkpointLayer;
    

    void Awake()
    {


        checkpointsParent = GameObject.Find("Checkpoints").transform;
        checkpointCount = checkpointsParent.childCount;
        checkpointLayer = LayerMask.NameToLayer("Checkpoint");
        
 
    }
    


    void StartLap()
    {
        Debug.Log("StartLap!");
        CurrentLap++;
        lastCheckpointPassed = 1;
        lapTimerTimestamp = Time.time;
    }

    void EndLap()
    {
        LastLapTime = Time.time - lapTimerTimestamp;
        BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
        Debug.Log("End Lap - LapTime was " + LastLapTime + "Seconds");

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer != checkpointLayer)
        {

         return;

        }

        //If this is the innital Checkpoint (Finish Line/Start Line)

        if (col.gameObject.name == "1")
        {
            //And all the checkpoints has been passed it ends the lap

            if (lastCheckpointPassed == checkpointCount)
            {
                EndLap();
            }

            //It this is the first lap or have passed the last checkpoint, we start a new Lap

            if (CurrentLap == 0 || lastCheckpointPassed == checkpointCount)
            {
                StartLap();
            }

             if (CurrentLap == 4)
            {

                 SceneManager.LoadScene("Menu");
            }
            else
            {
            return;
            }


        }
        

        //If we pass the next Checkpoint, update the last checkpoint, to avoid people skipping checkpoints
        if(col.gameObject.name == (lastCheckpointPassed+1).ToString())
        {   

            
            lastCheckpointPassed++;
             Debug.Log("Checkpoint: " + lastCheckpointPassed);
        }



    }

    void Update()
    {
        CurrentLapTime = lapTimerTimestamp > 0 ? Time.time - lapTimerTimestamp : 0;
    }

    

    
}
