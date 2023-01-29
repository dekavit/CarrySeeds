using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect1 : MonoBehaviour 
{
    private bool firstPush = false;
    // Start is called before the first frame update
    public void Slect1()
    {
        if (!firstPush)
        {
            Time.timeScale = 1f;
            //Debug.Log("Go Next Scene!");
            SceneManager.LoadScene(this.gameObject.name);
            firstPush = true;
        }
    }
}
