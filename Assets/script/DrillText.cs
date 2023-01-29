using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrillText : MonoBehaviour
{
    public Text Drill;
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
        Drill.text = Items.drill.ToString();
    }
}
