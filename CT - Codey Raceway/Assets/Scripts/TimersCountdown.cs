using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;
    public CodeyMove Speed;
    public bool PrintedTime;

    public float totalLapTime;
    public float totalCountdownTime;
    bool speedCHanged = false;
    // Update is called once per frame
    void Update()
    {
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            Speed.Speed = 0;
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            if (!speedCHanged)
            {
                Speed.Speed = 1000;
                speedCHanged  = true;
            }
        }

        if (totalLapTime < 0 && PrintedTime == false)
        {
            print("Time Is Up Buddy");
            PrintedTime = true;
        }



    

    }
}
