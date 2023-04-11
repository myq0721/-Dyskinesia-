using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ganxiexin_baozhi : MonoBehaviour
{
    public GameObject baozhitrigger,ganxiexintrigger;
    public GameObject baozhi,ganxiexin;
    public dia baozhidia;
    public dia ganxiexindia;
    bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
        baozhitrigger.SetActive(true);
        ganxiexintrigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(baozhidia.finish){
            baozhitrigger.SetActive(false);
            ganxiexintrigger.SetActive(true);
            finish = true;
        }
        if(finish && ganxiexindia.finish){
            SceneManager.LoadScene("4_gohos");
        }
    }
}
