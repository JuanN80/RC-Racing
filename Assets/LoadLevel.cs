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
    public Animator transition;
    public float transitionTime = 1;
    [SerializeField] int sceneNumber;





public void LoadNextLevel()
{
    
    StartCoroutine(LoadLevelNum(sceneNumber));



}

    IEnumerator LoadLevelNum(int levelnum)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelnum);
    }

   

    
}