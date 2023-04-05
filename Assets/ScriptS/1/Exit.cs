using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {

    public void OnStartGame()
    {
        SceneManager.LoadScene("1_Cover");
    }

    //退出游戏方法
    public void OnExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
