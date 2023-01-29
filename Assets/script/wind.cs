using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public float rightpower,uppower;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" | collision.tag == "seed")
        {
            collision.transform.Translate(rightpower, uppower, 0.0f);
        }
    }
}
