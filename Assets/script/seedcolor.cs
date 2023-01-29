using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedcolor : MonoBehaviour
{
    [SerializeField] Sprite[] sp;
    public int sc , ss;
    private float sss;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sp[sc];
        sss = (float)(ss * 0.125);
        this.gameObject.transform.localScale = new Vector3(sss, sss, sss);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
