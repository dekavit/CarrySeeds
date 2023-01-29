using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    private bool firstPush = false;
    // Start is called before the first frame update
    public void ExitGame()
    {
        if (!firstPush)
        {
            Application.Quit();
            Debug.Log("Exit");
            firstPush = true;
        }
    }
}
