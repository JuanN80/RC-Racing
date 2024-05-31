using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSpawn : MonoBehaviour
{
    private Transform posRespawn;
    public Transform posPlayer;
   
    public void DeadPlayer()
    {
        posPlayer.position = posRespawn.position;


    }
}
