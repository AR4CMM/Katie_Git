using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    bool timerReset = false;
    bool timerActive = false;
    public float timeValue = 1200;
    public TextMeshPro timerText;

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 1200;
                timerActive = false;
            }
            DisplayTime(timeValue);
        }
        if (timerReset == true)
        {
            timeValue = 1200;
            DisplayTime(timeValue);
            timerActive = false;
            timerReset = false;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }

    public void ResetTimer()
    {
        timerReset = true;
    }
}
