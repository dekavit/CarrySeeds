using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk2 : MonoBehaviour
{
    public int n;
    public bool[] keyArray = { false, false, false, false };
    [SerializeField] Sprite[] sp;
    public float s;
    GameObject player;
    GameObject joystick;
    public PauseScript pause;
    [SerializeField] private FixedJoystick _joystick;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        pause = player.GetComponent<PauseScript>();
        this.transform.localScale = new Vector3(s, s, s);
        joystick = GameObject.Find("Fixed Joystick");
        _joystick = joystick.GetComponent<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pause.stop == false)
        {
            float x = _joystick.Horizontal;
            float y = _joystick.Vertical;
            if (y>0)
            {
                keyArray[0] = true;
            }
            if (y<0)
            {
                keyArray[1] = true;
            }
            if (x<0)
            {
                keyArray[2] = true;
            }
            if (x>0)
            {
                keyArray[3] = true;
            }
            if (keyArray[0] && !keyArray[1])
            {
                n = 0;
            }
            else if (keyArray[2] && !keyArray[3])
            {
                n = 2;
            }
            else if (keyArray[3] && !keyArray[2])
            {
                n = 3;
            }
            else
            {
                n = 1;
            }
            GetComponent<SpriteRenderer>().sprite = sp[n];
            if (y>0)
            {
                keyArray[0] = false;
            }
            if (y<0)
            {
                keyArray[1] = false;
            }
            if (x<0)
            {
                keyArray[2] = false;
            }
            if (x>0)
            {
                keyArray[3] = false;
            }
        }
    }
}
