using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public Text timeText;
    public Text newHighscore;
    public float highTime;
    float minutes;
    float seconds;
    void Start()
    {


        highTime = PlayerPrefs.GetFloat("time", 0);
        timeText.text = "" + timeRemaining.ToString();
        newHighscore.text = "" + highTime.ToString("00:00");
    }
    void Update()
    {
       
        timeRemaining += Time.deltaTime;
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        


        if (highTime < timeRemaining)
           
        PlayerPrefs.SetFloat("time", timeRemaining);
        


    }

}
