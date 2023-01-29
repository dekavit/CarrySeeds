using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.PlayerPrefs;

public class DataDelete : MonoBehaviour
{
    private bool firstPush = false;
    // Start is called before the first frame update
    public void Delete1()
    {
        if (!firstPush)
        {
            Time.timeScale = 1f;
            PlayerPrefs.DeleteKey(this.gameObject.name + "_highscore");
            firstPush = true;
        }
    }
}
