using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

private TrackCheckpoints abc;
   private void OnTriggerEnter(Collider col)
    {
        
        if(col.);
        {
            abc.PlayerThroughCheckpoint(this);
            
        }




    }

    public void SetTrackCheckPoints(TrackCheckpoints checkpointa)
    {
        abc = checkpointa;


    }

    
}
