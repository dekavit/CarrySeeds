using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.PlayerPrefs; //データ保存
using UnityEngine.SceneManagement; //シーン確認用

public class Score : MonoBehaviour
{
    public Text scoreText; //スコア表示
    public Text highscore_text; //ハイスコア表示
    public int score , JC , DC , TS , SS , DS , DWS;
    private int highScore; //ハイスコア
    private string key; //データ整理用
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (score > highScore) {
            highScore = score;
            PlayerPrefs.SetInt(key, highScore); //ハイスコア再設定
            highscore_text.text = "HighScore: " + highScore.ToString();
        }
    }
    private void Initialize()
    {
        score = 0;
        //シーン取得、キー設定
        key = SceneManager.GetActiveScene().name + "_highscore";
        highScore = PlayerPrefs.GetInt(key, 0); //ハイスコア取得
        highscore_text.text = "HighScore: " + highScore.ToString();
    }
}
