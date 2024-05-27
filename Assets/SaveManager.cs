using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;

/*
Author: S Neira Galvis
Class Name: SaveManager
Purpose:Saving System to store Players information

*/



public class SaveManager : MonoBehaviour
{
    public static SaveManager instance 
    {

        get; private set;
    }

//Variables for things inside the save

public int currentCar;
    private void Awake()

    //to load Saved data file at the start of the game
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
            Load();
        }

    }
    //Method to load data file
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            currentCar = data.currentCar;

            file.Close();

        }

    }

    //Method to save the user data in whatever directory the system thinks is best
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();

       
        bf.Serialize(file,data);
        file.Close();
    }

    [Serializable]

    //Variables we are storing
    class PlayerData_Storage
    {
        public int currentCar;
    }


} 
