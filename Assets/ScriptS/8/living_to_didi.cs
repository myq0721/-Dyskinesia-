using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class living_to_didi : MonoBehaviour
{
    public GameObject texterror;
    private bool lightactive = true;
    private float timer = 0;
    private int param;
    // Start is called before the first frame update
    void Start()
    {
        param = GameObject.Find("GameData").GetComponent<GameData>().param;
        Debug.Log(param);
    }

    // Update is called once per frame
    void Update()
    {
        if(texterror.active){
            Debug.Log(timer);
            timer += Time.deltaTime;
            if(timer >= 1f){
                texterror.SetActive(false);
                timer = 0;
            }
        }
    }
    private void OnTriggerStay(Collider other) {
        if(Input.GetKeyDown(KeyCode.F)){
            if(param == 2)
                SceneManager.LoadScene("10_didi");
            else
                texterror.SetActive(true);
        }
    }
}
