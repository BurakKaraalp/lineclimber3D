using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("t");
        if(other.gameObject.tag == "FinishPoint")
        {
            setLevel();
            loadLevel();
        }
    }


    public void setLevel()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        PlayerPrefs.SetInt("levelint", sceneLoaded.buildIndex+1);
        PlayerPrefs.Save();
    }
    void loadLevel()
    {
        int bolumid = PlayerPrefs.GetInt("levelint");
        SceneManager.LoadScene(bolumid);
        Debug.Log(bolumid);
    }

}
