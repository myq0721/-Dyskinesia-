using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//没想到好的解决办法，先单开一个空物体控制esc和player的唯一性
public class Playeresc : MonoBehaviour
{
    public GameObject player;
    public GameObject escpanel;

    void Update()
    {
        if(escpanel.activeSelf){
            player.SetActive(false);
        }
        else{
            player.SetActive(true);
        } 
    }
}
