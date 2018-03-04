using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finnished = false;
	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        if (finnished)
            return;
        
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");

        timerText.text = "Timer: " + minutes + " : " + sec;
    }

    public void Finnish(){
        finnished = true;
        timerText.color = Color.yellow;
    }
}
