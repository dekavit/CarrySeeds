using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour 
{
    private bool firstPush = false;
    // Start is called before the first frame update
    public void aaaaaa()
    {
        if (!firstPush)
        {
            SceneManager.LoadScene("Select");
            firstPush = true;
        }
    }
    public void iiiiii()
    {
        if (!firstPush)
        {
            SceneManager.LoadScene("DataDelete");
            firstPush = true;
        }
    }
}
