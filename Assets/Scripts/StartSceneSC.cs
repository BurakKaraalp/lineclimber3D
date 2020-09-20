using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneSC : MonoBehaviour
{
    private void Awake()
    {
        bool levelstatbool = false;
        int levelint = PlayerPrefs.GetInt("levelint");
        int maxScene = 2;
        if (PlayerPrefs.GetInt("levelstat") == 1)
        {
            levelstatbool = true;
        }
        if (levelint == 2)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("levelint"), LoadSceneMode.Single);
        }
        if (levelstatbool == false)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        if(levelint > maxScene)
        {
            SceneManager.LoadScene(maxScene, LoadSceneMode.Single);
        }
    }
}
