using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uekibaticolor : MonoBehaviour
{
    [SerializeField] Sprite[] sp;
    public int uc;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sp[uc];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
