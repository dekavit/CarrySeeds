using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class needseed : MonoBehaviour
{
    GameObject Clear_hantei;
    public clear_hantei clear_HanteiScript;
    public Text needseedtext;
    // Start is called before the first frame update
    void Start()
    {
        Clear_hantei = GameObject.Find("Clear_hantei");
        clear_HanteiScript = Clear_hantei.GetComponent<clear_hantei>();
    }

    // Update is called once per frame
    void Update()
    {
        needseedtext.text = "残り" + (clear_HanteiScript.need - clear_HanteiScript.clear).ToString("0") + "輪";
    }
}
