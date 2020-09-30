using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUsed : MonoBehaviour
{
    public Text time;

    public float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minuits = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        time.text = minuits + ":" + seconds;

    }
}
