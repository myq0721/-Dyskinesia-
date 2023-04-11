using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public int param = 0;//0为没有镊子，1为有镊子
 
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}