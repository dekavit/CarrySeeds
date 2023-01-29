using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillWall : MonoBehaviour
{
    GameObject player;
    public bool br = false;
    public PlayerItems Items;
    GameObject scoreboard;
    public Score scoreScript;
    GameObject drill;
    drillbutton Drillbutton;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Items = player.GetComponent<PlayerItems>();
        scoreboard = GameObject.Find("scoreboard");
        scoreScript = scoreboard.GetComponent<Score>();
        drill = GameObject.Find("DB");
        Drillbutton = drill.GetComponent<drillbutton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (br == true && Items.drill > 0 && Drillbutton.drillbool == true)
        {
            Drillbutton.drillbool = false;
            Destroy(this.gameObject);
            Items.drill -= 1;
            scoreScript.score -= scoreScript.DWS;
        }
        else if (Drillbutton.drillbool == true) Drillbutton.drillbool = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "drillhantei")
        {
            br = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "drillhantei")
        {
            br = false;
        }
    }
    public void Destroy()
    {

    }
}
