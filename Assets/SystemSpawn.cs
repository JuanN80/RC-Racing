using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSpawn : MonoBehaviour
{
    public Transform posRespawn;
    public Transform posPlayer;
   
    public void DeadPlayer()
    {
        posPlayer.position = posRespawn.position;


    }
}
