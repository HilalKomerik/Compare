using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [SerializeField]
    private Text durationText;

    int remainingTime;
    bool timeSituation;
    void Start()
    {
        remainingTime = 90;
        timeSituation = true;
        
    }

    IEnumerator DurationTimeRoutine()
    {
        while (timeSituation)
        {
            yield return new WaitForSeconds(1f);

            if (remainingTime<10)
            {
                durationText.text = "0" + remainingTime.ToString();
            }else
            {
                durationText.text = remainingTime.ToString();
            }

            if (remainingTime <= 0)
            {
                timeSituation = false;
                durationText.text = "00";
            }

            remainingTime--;
        }
    }

    public void StartTime()
    {
        StartCoroutine(DurationTimeRoutine());
    }

}
