using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gege_to_living : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other) {
        if(Input.GetKeyDown(KeyCode.F)){
            SceneManager.LoadScene("8_LivingRoom");
            Debug.Log("返回客厅");
        }
    }
}
