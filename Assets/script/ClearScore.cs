using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.PlayerPrefs; //データ保存
using UnityEngine.SceneManagement; //シーン確認用

public class ClearScore : MonoBehaviour
{
    public Text CS;
    GameObject scoreboard;
    public Score ScoreScript;
    public Timer TimeScript;
    private string key;
    private int score, highScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.Find("scoreboard");
        ScoreScript = scoreboard.GetComponent<Score>();
        TimeScript = scoreboard.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        score = ScoreScript.score + (((int)TimeScript.seconds) * ScoreScript.TS);
        //シーン取得、キー設定
        key = SceneManager.GetActiveScene().name + "_highscore";
        highScore = PlayerPrefs.GetInt(key, 0); //ハイスコア取得
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(key, highScore); //ハイスコア再設定
        }
        CS.text = score.ToString();
    }
}
