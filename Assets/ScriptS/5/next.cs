using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public dia usingdia;
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene ();
    }

    // Update is called once per frame
    void Update()
    {
        if(usingdia.finish){
            if(scene.name == "5_hos")
            SceneManager.LoadScene("6_hos2");
            if(scene.name == "7_coffee")
            SceneManager.LoadScene("8_LivingRoom");
        }
    }
}
