using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiugui : MonoBehaviour
{
    public GameObject elsetext, yes, no;
    public int param;
    // Start is called before the first frame update
    void Start()
    {
        param = GameObject.Find("GameData").GetComponent<GameData>().param;
        Debug.Log(param);
        elsetext.SetActive(false);
        yes.SetActive(false);
        no.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.F)){
            elsetext.SetActive(true);
            if(param == 0){
                no.SetActive(true);
                yes.SetActive(false);
                elsetext.SetActive(false);
            }else if(param == 1){
                yes.SetActive(true);
                no.SetActive(false);
                elsetext.SetActive(false);
            }
        }
    }
}
