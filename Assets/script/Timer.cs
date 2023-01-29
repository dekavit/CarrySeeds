using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public float seconds, defaultseconds;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        seconds = defaultseconds;
    }

    // Update is called once per frame
    void Update()
    {
        if(seconds > 0f)
        {
            seconds -= Time.deltaTime;
            timerText.text = ((int)seconds).ToString("0");
        }
        else if(seconds <= 0f)
        {

        }
    }
}
