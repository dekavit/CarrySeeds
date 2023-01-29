using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageselect : MonoBehaviour
{
    private bool firstPush = false;
    public bool select = false;
    // Start is called before the first frame update
    public void Slect1()
    {
        if (!firstPush)
        {
            select = true;
            SceneManager.LoadScene("Select");
            firstPush = true;
        }
    }
}
