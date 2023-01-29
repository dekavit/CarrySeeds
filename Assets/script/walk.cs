using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    GameObject player;
    public walk2 walk2Script;
    public PauseScript pause;
    public float speed,Defaultspeed;
    [SerializeField] private FixedJoystick _joystick;
    GameObject joystick;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        walk2Script = player.GetComponent<walk2>();
        pause = player.GetComponent<PauseScript>();
        joystick = GameObject.Find("Fixed Joystick");
        _joystick = joystick.GetComponent<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.stop == false)
        {
            float x = _joystick.Horizontal*speed;
            float y = _joystick.Vertical*speed;
            this.transform.Translate(x, y, 0f);
            /*if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0.0f, speed, 0.0f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0.0f, -speed, 0.0f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(-speed, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(speed, 0.0f, 0.0f);
            }*/
        }
    }
}
