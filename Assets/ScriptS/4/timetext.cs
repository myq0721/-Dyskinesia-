using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timetext : MonoBehaviour
{
    public Scene scene;
    public float waittime = 1f;
    private float timer = 0;
    public GameObject[] dialogue;
    public GameObject parent;
    private int dialoguelong = 0, nowdia = 1;
    public bool finish = false;
    void Start()
    {
        scene = SceneManager.GetActiveScene ();
        dialoguelong = dialogue.Length;
        Debug.Log("文本条数：" + dialoguelong);
        if(parent.active){
            dialogue[0].SetActive(true);
        }
        for(int i = 1; i < dialoguelong; i++){
            dialogue[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("nowdia:" + nowdia);
        timer += Time.deltaTime;
        Debug.Log("timer:" + timer);
        if(timer >= waittime){
            Textnext();
            timer = 0;
        }
    }
    void Textnext(){
        if(nowdia >= dialoguelong){
            parent.SetActive(false);
            finish = true;
        }
        else{
            dialogue[nowdia - 1].SetActive(false);
            dialogue[nowdia].SetActive(true);
            nowdia++;
        }
        if(finish){
            if(scene.name == "4_gohos")
                SceneManager.LoadScene("5_A");
            if(scene.name == "6_hos2")
                SceneManager.LoadScene("7_coffee");
        }
    }
}