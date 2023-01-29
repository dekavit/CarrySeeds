using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedItem : MonoBehaviour
{
    public Text SpeedText;
    GameObject player;
    public PlayerItems Items;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Items = player.GetComponent<PlayerItems>();
    }

    // Update is called once per frame
    void Update()
    {
        SpeedText.text = Items.speedup.ToString();
    }
}
