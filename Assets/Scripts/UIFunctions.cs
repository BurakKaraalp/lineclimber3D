using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    public GameObject StopPanelBackground,barDocs,stopButton;
    public void StopButton()
    {
        StopPanelBackground.gameObject.SetActive(true);
        Time.timeScale = 0;
        barDocs.SetActive(false);
        stopButton.SetActive(false);
        Handheld.Vibrate();   
    }
    public void MusicSettingsButton()
    {
        //müzik kapatma ayarları
    }
    public void HomeButton()
    {
        //tıklayınca home isimli scene yükleyecek
    }
    public void LevelsButton()
    {
        //tıklayınca levels isimli scene yükleyecek
    }
    public void PlayButton()
    {
        StopPanelBackground.gameObject.SetActive(false);
        barDocs.SetActive(true);
        stopButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void NextLevel()
    {
        Time.timeScale = 1;
        int bolumid = PlayerPrefs.GetInt("levelint");
        Debug.Log(bolumid);
        SceneManager.LoadScene(bolumid);
    }

}
