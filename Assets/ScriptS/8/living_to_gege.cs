using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class living_to_gege : MonoBehaviour
{
    public GameObject light;
    public GameObject texterror;
    private bool lightactive = true;
    private float timer = 0;
    private bool boolstay = false;
    // Start is called before the first frame update
    void Start()
    {
        texterror.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(texterror.active){
            timer += Time.deltaTime;
            if(timer >= 1f){
                texterror.SetActive(false);
                timer = 0;
            }
        }

        if(light.active){
            lightactive = true;
        }else{
            lightactive = false;
        }
        if(Input.GetKeyDown(KeyCode.F) && boolstay){
            Debug.Log("press f " + lightactive);
            if(!lightactive)
                SceneManager.LoadScene("9_gege");
            else
                texterror.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other) {
        boolstay = true;
    }
    private void OnTriggerExit(Collider other) {
        boolstay = false;
    }
}
