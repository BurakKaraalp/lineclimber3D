using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed;
    float distanceTravelled;
    bool touchStat;
    public GameObject overPanel,str1,str2,str3;
    private void Start()
    {
        //ekranı portrait'e sabitleme.
        Screen.orientation = ScreenOrientation.Portrait;
        //Gölgeleri Kapatma
        QualitySettings.shadows = ShadowQuality.Disable;
        if(PlayerPrefs.GetInt("dieCounter") == 0 )
        {
            PlayerPrefs.SetInt("dieCounter", 0);
        }
           
    }
    private void FixedUpdate()
    {
        if(touchStat == true)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ClickPoint")
        {
            Debug.Log("Te4");
        }
    }

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                touchStat = true;  
            }
            if(touch.phase == TouchPhase.Ended)
            {
                touchStat = false;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinishPoint")
        {
            overPanel.SetActive(true);
            setLevel();
            
        }
        if(other.gameObject.tag == "Trap")
        {
            int dieCounter = PlayerPrefs.GetInt("dieCounter");
            PlayerPrefs.SetInt("dieCounter", dieCounter + 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public float[] CallPathInt()
    {
        //stats[0] = Katedilen mesafe stats[1] = Toplam Mesafe
        float[] stats = {distanceTravelled, pathCreator.path.length};
        return stats;
    }
    public void setLevel()
    {
        int dieCounter = PlayerPrefs.GetInt("dieCounter");
        if(dieCounter <= 2)
        {
            Debug.Log(dieCounter);
            str1.SetActive(false);
            str2.SetActive(false);
            str3.SetActive(false);
            PlayerPrefs.SetInt("dieCounter",0);
        }
        else if(dieCounter <= 3)
        {
            Debug.Log(dieCounter);
            str1.SetActive(false);
            str2.SetActive(false);
            PlayerPrefs.SetInt("dieCounter",0);
        }
        else if(dieCounter >= 4)
        {
            Debug.Log(dieCounter);
            str1.SetActive(false);
            PlayerPrefs.SetInt("dieCounter",0);

        }
        Time.timeScale = 0;
        Scene sceneLoaded = SceneManager.GetActiveScene();
        PlayerPrefs.SetInt("levelint", sceneLoaded.buildIndex + 1);
        PlayerPrefs.Save();
    }
    void loadLevel()
    {
        int bolumid = PlayerPrefs.GetInt("levelint");
        SceneManager.LoadScene(bolumid);
    }   
    
}
