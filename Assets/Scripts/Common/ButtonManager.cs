using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    /// <summary>
    /// シーン切り替え処理
    /// </summary>
    public void OnSceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
