using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public GameObject UIRacePanel;
    public TextMeshProUGUI textCurrentLap;
    public TextMeshProUGUI textCurrentTime;
    public TextMeshProUGUI textLastLapTime;
    public TextMeshProUGUI textBestLapTime;
    private Player UpdateUIForPlayer;
    private int CurrentLap = -1;
    private float CurrentLapTime;
    private float LastLapTime;
    private float BestLapTime;

    void Start()
    {


    // Find all GameObjects with the tag "Player"
    GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");

    // Iterate over each GameObject and get the Player component
    foreach (GameObject playerObject in playerObjects)
    {
    UpdateUIForPlayer = playerObject.GetComponent<Player>();

    
    if (UpdateUIForPlayer != null)
    {
      
    }
    }



    }



    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (UpdateUIForPlayer == null)
        {

            return;
        }
        if(UpdateUIForPlayer.CurrentLap != CurrentLap)
        {
            CurrentLap = UpdateUIForPlayer.CurrentLap;
            textCurrentLap.SetText("LAP: " + CurrentLap);
        }

        if(UpdateUIForPlayer.CurrentLapTime != CurrentLapTime)
        {
            CurrentLapTime = UpdateUIForPlayer.CurrentLapTime;
            textCurrentTime.text = $"TIME: { (int)CurrentLapTime/60}:{(CurrentLapTime) % 60:00.000}";
        }

        if(UpdateUIForPlayer.LastLapTime != LastLapTime)
        {
            LastLapTime = UpdateUIForPlayer.LastLapTime;
            textLastLapTime.text = $"LAST: { (int) LastLapTime/60}:{(LastLapTime) % 60:00.000}";
        }

        if(UpdateUIForPlayer.BestLapTime != BestLapTime)
        {
            BestLapTime = UpdateUIForPlayer.BestLapTime;
            textBestLapTime.text = BestLapTime<10000000 ?  $"BEST: { (int) BestLapTime/60}:{(BestLapTime) % 60:00.000}" : "BEST: N/A";
        }
        
    }
}
