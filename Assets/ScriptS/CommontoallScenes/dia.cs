using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dia : MonoBehaviour
{
    public GameObject[] dialogue;
    public GameObject parent;
    private int dialoguelong = 0, nowdia = 1;
    public bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
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
        if(Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0)){
            Debug.Log("nowdia" + nowdia);
            if(nowdia >= dialoguelong){
                parent.SetActive(false);
                finish = true;
            }
            else{
                dialogue[nowdia - 1].SetActive(false);
                dialogue[nowdia].SetActive(true);
                nowdia++;
            }
        }
    }
}
