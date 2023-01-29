using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersubspeedup : MonoBehaviour
{
    GameObject speed;
    GameObject playersub;
    public walk Speed;
    public speedbutton SpeedbuttonSc;
    // Start is called before the first frame update
    void Start()
    {
        speed = GameObject.Find("speed");
        playersub = GameObject.Find("playersub");
        Speed = playersub.GetComponent<walk>();
        SpeedbuttonSc = speed.GetComponent<speedbutton>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SpeedbuttonSc.SpeedEffect == true)
        {
            Speed.speed = SpeedbuttonSc.up;
        }
        else if(SpeedbuttonSc.SpeedEffect == false)
        {
            Speed.speed = Speed.Defaultspeed;
        }
    }
}
