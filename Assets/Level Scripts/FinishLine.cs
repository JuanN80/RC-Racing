using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player");
        {
            SceneManager.LoadScene("Menu");
        }
       

    }

}
   
