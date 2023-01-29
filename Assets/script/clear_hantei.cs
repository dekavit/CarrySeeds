using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear_hantei : MonoBehaviour
{
    [SerializeField]
    private GameObject ClearPrefab;
    private GameObject ClearInstance;
    public int clear, need, perfect;
    public bool cl = false;
    GameObject player;
    public PauseScript pause;
    GameObject scoreboard;
    public Timer timerScript;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        pause = player.GetComponent<PauseScript>();
        scoreboard = GameObject.Find("scoreboard");
        timerScript = scoreboard.GetComponent<Timer>();
        clear = 0;
        perfect = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(clear == need)
        {
            if (timerScript.seconds >= 0)
            {
                cl = true;
                if (ClearInstance == null)
                {
                    ClearInstance = GameObject.Instantiate(ClearPrefab) as GameObject;
                    pause.stop = true;
                    Time.timeScale = 0f;
                }
            }
        }
    }
}
