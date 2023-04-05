using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public float waittime = 6f;//等待时间
    private float timer = 0f;//计时器
    public bool boolstart = false;//StartGame()标志符

    public bool booltrans = false;//动画标志符
    public GameObject transition;
    public GameObject trans1;
    public GameObject trans2;
    public float transwaittime = 3f;//等待时间
    private float transtimer = 0f;//计时器
    // public float colorspeed = 0.2f;

    void Start(){
        transition.SetActive(false);
        trans1.SetActive(true);
        trans2.SetActive(false);
    }

    void Update(){
        if (boolstart){
            timer += Time.deltaTime;
            if(timer > waittime){    
                SceneManager.LoadScene("2_Corridor");
                Debug.Log("load");
            }
        }
        if(booltrans){
            transtimer += Time.deltaTime;
            if(transtimer > transwaittime){
                trans1.SetActive(false);
                trans2.SetActive(true);
            }
        }
    }

    //开始游戏的方法
    public void StartGame()
    {   
        boolstart = true;

        Transitionanimation();
        Debug.Log(boolstart);
    }

    //过渡动画
    private void Transitionanimation()
    {
        transition.SetActive(true);
        booltrans = true;
    }
}
