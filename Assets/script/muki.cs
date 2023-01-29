using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muki : MonoBehaviour
{
    public float s;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            this.transform.localScale = new Vector3(s, s, s);
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -90f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -90f);
            this.transform.localScale = new Vector3(-s, s, s);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            this.transform.localScale = new Vector3(-s, s, s);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            this.transform.localScale = new Vector3(s, s, s);
        }


    }
}
