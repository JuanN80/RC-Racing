using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScreen : MonoBehaviour
{
    public LoadLevel loadLevel;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.Space))
         {

          loadLevel.LoadNextLevel();
         }
    }
}
