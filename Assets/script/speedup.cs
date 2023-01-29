using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedup : MonoBehaviour
{
    GameObject player;
    public PlayerItems Items;
    GameObject scoreboard;
    public Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Items = player.GetComponent<PlayerItems>();
        scoreboard = GameObject.Find("scoreboard");
        scoreScript = scoreboard.GetComponent<Score>();
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Items.speedup = Items.speedup + 1;
            scoreScript.score += scoreScript.SS;
            Destroy(this.gameObject);
        }
    }
}