using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneSC : MonoBehaviour
{
    private void Awake()
    {
        int sceneCount = SceneManager.sceneCount;
        Debug.Log(sceneCount);
        int sceneInt = PlayerPrefs.GetInt("levelint");
        SceneManager.LoadScene(sceneInt, LoadSceneMode.Single);
    }
}
