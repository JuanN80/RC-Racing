using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player");
        {
            finishLine.LoadLevelNum(1);

        }




    }

    
}
