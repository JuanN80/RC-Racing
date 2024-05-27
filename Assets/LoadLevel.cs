using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadLevelNum(int levelnum)
    {

        SceneManager.LoadScene(levelnum);
    }

    
}