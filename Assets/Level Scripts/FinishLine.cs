using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private LoadLevel finishLine;
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player" || );
        {
            finishLine.LoadLevelNum(1);

        }
       

    }




}
   
