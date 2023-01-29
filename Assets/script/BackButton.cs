using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private bool firstPush = false;
    // Start is called before the first frame update
    public void Slect1()
    {
        if (!firstPush)
        {
            SceneManager.LoadScene("Main");
            firstPush = true;
        }
    }
}
