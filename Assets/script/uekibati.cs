using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uekibati : MonoBehaviour
{
    private long putOnTime = 0;
    public int grow = 0;
    public bool putOnBool = false;
    public int growTime = 0;
    [SerializeField] Sprite[] rsp,pp,ysp,psp,gsp;
    public int uc, us;
    private bool pc = false , a = false;
    GameObject scoreboard;
    public Score scoreScript;
    GameObject Clear_hantei;
    public clear_hantei clear_HanteiScript;
    public Timer timerScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.Find("scoreboard");
        scoreScript = scoreboard.GetComponent<Score>();
        GetComponent<SpriteRenderer>().sprite = pp[uc];
        Clear_hantei = GameObject.Find("Clear_hantei");
        clear_HanteiScript = Clear_hantei.GetComponent<clear_hantei>();
        timerScript = scoreboard.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grow != 4 && grow != 0 && DateTimeOffset.Now.ToUnixTimeSeconds() > putOnTime + growTime*grow)
        {
            if (timerScript.seconds >= 0.001)
            {
                if (uc == 0)
                {
                    grow++;
                    GetComponent<SpriteRenderer>().sprite = rsp[grow];
                    //Debug.Log(grow);
                }
                else if (uc == 1)
                {
                    grow++;
                    GetComponent<SpriteRenderer>().sprite = gsp[grow];
                    //Debug.Log(grow);
                }
                else if (uc == 2)
                {
                    grow++;
                    GetComponent<SpriteRenderer>().sprite = psp[grow];
                    //Debug.Log(grow);
                }
                else if (uc == 3)
                {
                    grow++;
                    GetComponent<SpriteRenderer>().sprite = ysp[grow];
                    //Debug.Log(grow);
                }

            }
        }
        else if (grow == 4 && pc == true && a == false)
        {
            scoreScript.score += scoreScript.JC;
            clear_HanteiScript.clear += 1;
            clear_HanteiScript.perfect += 1;
            a = true;
        }
        else if (grow == 4 && pc == false && a == false)
        {
            scoreScript.score += scoreScript.DC;
            clear_HanteiScript.clear += 1;
            a = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("seed") && putOnTime == 0)
        {
            seedcolor seedscript = other.gameObject.GetComponent<seedcolor>();
            if (seedscript.ss == us)
            {
                putOnTime = DateTimeOffset.Now.ToUnixTimeSeconds();
                grow++;
                if (uc == 0)
                {
                    GetComponent<SpriteRenderer>().sprite = rsp[grow];
                    //Debug.Log(grow);
                }
                else if (uc == 1)
                {
                    GetComponent<SpriteRenderer>().sprite = gsp[grow];
                    //Debug.Log(grow);
                }
                else if (uc == 2)
                {
                    GetComponent<SpriteRenderer>().sprite = psp[grow];
                    //Debug.Log(grow);

                }
                else if (uc == 3)
                {
                    GetComponent<SpriteRenderer>().sprite = ysp[grow];
                    //Debug.Log(grow);
                }
                if (seedscript.sc == uc)
                {
                    //Debug.Log("oka");
                    pc = true;
                }
                else if (seedscript.sc != uc)
                {
                    //Debug.Log("okb");
                    pc = false;
                }
            }
        }
    }
}
