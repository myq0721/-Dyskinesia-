using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public GameObject[] text;
    private int textlong;
    private float waittime = 2f, timer = 0;
    private int processmanagement = 0;
    // Start is called before the first frame update
    void Start()
    {
        textlong = text.Length;
        Debug.Log("textlong" + textlong);
        text[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= waittime){
            if(processmanagement == 0)
                text[0].SetActive(true);
            if(processmanagement == 1){
                text[0].SetActive(false);
                SceneManager.LoadScene("5_hos");
            }
            processmanagement++;
            timer = 0;
        }
    }
}
