using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteseed : MonoBehaviour
{
    public seedcolor seedcolorScript;
    void Start()
    {
        seedcolorScript = this.gameObject.GetComponent<seedcolor>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("ok1");
        if (collision.gameObject.tag == "uekibati")
        {
            uekibati uekibatiScript = collision.gameObject.GetComponent<uekibati>();
           // Debug.Log("ok2");
            if(!uekibatiScript.putOnBool && uekibatiScript.us == seedcolorScript.ss)
            {
                uekibatiScript.putOnBool = true;
                Destroy(this.gameObject);
            }
        }
    }



}
