using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countdown;

    public Text startCountdown;

    //Start :)
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown > 0)
        {
            startCountdown.text = Mathf.Round(countdown).ToString();
        }

        if (countdown < 0)
        {
            print("You Lose");
            SceneManager.LoadScene(1);
        }
    }
}
