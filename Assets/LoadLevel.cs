using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
Author: S Neira Galvis
Class Name: LoadLevel
Purpose: Class used to select the level/scene we want to load
*/

public class LoadLevel : MonoBehaviour
{
    public void LoadLevelNum(int levelnum)
    {

        SceneManager.LoadScene(levelnum);
    }

    
}