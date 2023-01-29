using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    private bool firstPush = false;
    public Scene loadScene;
     void Start()
    {
        Scene loadScene = SceneManager.GetActiveScene();
    }
    public void Slect1()
    {
        if (!firstPush)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            firstPush = true;
        }
    }
}
