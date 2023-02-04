using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Timer : MonoBehaviour

{
    [SerializeField] private float timeValue = 9;
    [SerializeField] private GameObject timeText;
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;

    void Update()
    {
        if (timeValue > 0)

        {

            timeValue -= Time.deltaTime;
        }

        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);

        //if (timeText != null)

        //{
        //    Button1.SetActive(false);
        //    Button2.SetActive(false);

        //}


    }

    void DisplayTime(float timeToDisplay)

    {
        if (timeToDisplay < 0)

        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);


        timeText.GetComponent<TextMeshProUGUI>().text = string.Format("{0:00}", seconds);
    }
}
