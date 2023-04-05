using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
  public GameObject escpanel;

    // Start is called before the first frame update
    // void Start()
    // {
    //     if(gameObject.name == "Esc")
    //         gameObject.SetActive(false);
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            escfun();
        }
    }
    public void escfun(){
        if(escpanel.activeSelf){
            escpanel.SetActive(false);
        }
        else{
            escpanel.SetActive(true);
        } 
    }
}
