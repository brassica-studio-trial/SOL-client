using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleSceneController : MonoBehaviour
{

    // Inspector上で次のシーン名を設定
    public string nextSceneName;

    void changeNext()
    {
        if (Time.timeSinceLevelLoad > 3.0f)
        {
            nextSceneName = "Main";
            SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
        changeNext();
    }

}