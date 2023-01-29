using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover_hantei : MonoBehaviour
{
    [SerializeField]
    private GameObject GameoverUIPrefab;
    private GameObject GameoverUIInstance;
    GameObject scoreboard;
    public Timer timerScript;
    public bool Ga = false;
    GameObject player;
    public PauseScript pause;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.Find("scoreboard");
        timerScript = scoreboard.GetComponent<Timer>();
        player = GameObject.Find("player");
        pause = player.GetComponent<PauseScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerScript.seconds < 0.001)
        {
            Ga = true;
            if (GameoverUIInstance == null)
            {
                GameoverUIInstance = GameObject.Instantiate(GameoverUIPrefab) as GameObject;
                pause.stop = true;
                Time.timeScale = 0f;
            }
        }
    }
}
