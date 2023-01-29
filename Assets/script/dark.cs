using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dark : MonoBehaviour
{
    GameObject MainCamera;
    public bool de = false;
    public float camerasize , defaultcamerasize;
    public Camera ca;
    // Start is called before the first frame update
    void Start()
    {
        ca = GameObject.Find("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            de = true;
            ca.orthographicSize = camerasize;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            de = false;
            ca.orthographicSize = defaultcamerasize;
        }
    }

}
