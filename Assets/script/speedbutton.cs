﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedbutton : MonoBehaviour
{
    GameObject player;
    public PlayerItems Items;
    public PauseScript pause;
    public walk Speed;
    public bool SpeedEffect = false;
    public float up;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Items = player.GetComponent<PlayerItems>();
        Speed = player.GetComponent<walk>();
        pause = player.GetComponent<PauseScript>();
    }

    // Update is called once per frame
    public void speed()
    {
        if (Items.speedup > 0 && pause.stop == false)
        {
            if (SpeedEffect == false)
            {
                    Items.speedup = Items.speedup - 1;
                    SpeedEffect = true;
                    Speed.speed = up;
                    Invoke("SpeedDown", time);
            }
        }
    }
    void SpeedDown()
    {
        Speed.speed = Speed.Defaultspeed;
        SpeedEffect = false;
    }
}
