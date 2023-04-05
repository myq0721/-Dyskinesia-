using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Trigger_A : MonoBehaviour {
    public GameObject tishi;
    public GameObject text;
    private bool booltext = false; 

    void Start() {
        tishi.SetActive(false);
        text.SetActive(false);
    }
    void Update(){
        if(booltext && Input.GetKeyDown(KeyCode.F)){
            text.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        tishi.SetActive(true);
        booltext = true;
    }
    void OnTriggerExit(Collider other)
    {
        booltext = false;
        tishi.SetActive(false);
        text.SetActive(false);
    }
}