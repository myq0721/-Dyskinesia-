using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class tv : MonoBehaviour
{
    public GameObject ye, er,parent,tv12,tv20,tvelse;
    public TMP_InputField input;
    public TMP_Text text;
    private string a;
    public void OnClick()
    {
        text.text = input.text;
        a = input.text;
        Debug.Log("Click" + text.text);
        if(a == "12"){
            er.SetActive(false);
            ye.SetActive(true);
            tv12.SetActive(true);
            tv20.SetActive(false);
            tvelse.SetActive(false);
            Debug.Log(a);
        }else if(a == "20"){
            er.SetActive(false);
            ye.SetActive(true);
            tv20.SetActive(true);
            tv12.SetActive(false);
            tvelse.SetActive(false);
            Debug.Log(a);
        }else{
            er.SetActive(true);
            ye.SetActive(false);
            tvelse.SetActive(true);
            tv12.SetActive(false);
            tv20.SetActive(false);
            Debug.Log("error!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ye.SetActive(false);
        er.SetActive(true);
        tv12.SetActive(false);
        tv20.SetActive(false);
        tvelse.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            parent.SetActive(false);
        }
    }
}
