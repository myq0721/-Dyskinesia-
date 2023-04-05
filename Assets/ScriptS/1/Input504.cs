using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Input504 : MonoBehaviour
{
    public GameObject ye, er;

    public TMP_InputField input;
    public TMP_Text text;
    private string a;
    public void OnClick()
    {
        text.text = input.text;
        a = input.text;
        Debug.Log("Click" + text.text);
        if(a == "1323"){
            er.SetActive(false);
            Debug.Log("yes!");
            ye.SetActive(true);
        }else{
            Debug.Log("error!");
            er.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ye.SetActive(false);
        er.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
