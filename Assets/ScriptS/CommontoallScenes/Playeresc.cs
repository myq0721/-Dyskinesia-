using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//没想到好的解决办法，先单开一个空物体控制esc和player的唯一性
public class Playeresc : MonoBehaviour
{
    public GameObject player;
    public GameObject[] banplayer;
    public GameObject escpanel;

    private bool isbanpalyer(){
        for(int i=  0; i < banplayer.Length; i++){
            if(banplayer[i].active){
                return true;
            }
        }
        return false;
    }
    void Update()
    {
        if(escpanel.active || isbanpalyer()){
            player.SetActive(false);
        }else{
            player.SetActive(true);
        }
    }
}
