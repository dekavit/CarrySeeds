using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
	[SerializeField]
	//　ポーズした時に表示するUIのプレハブ
	private GameObject pauseUIPrefab;
	//　ポーズUIのインスタンス
	public GameObject pauseUIInstance;

	public stageselect stageselectScript;

	GameObject Clear_hantei;

	public clear_hantei Clear_HanteiScript;

	public bool stop = false;

	GameObject Gameover_hantei;

	public Gameover_hantei gameover_HanteiScript;

    void Start()
    {
		Clear_hantei = GameObject.Find("Clear_hantei");
		Clear_HanteiScript = Clear_hantei.GetComponent<clear_hantei>();
		Gameover_hantei = GameObject.Find("Gameover_hantei");
		gameover_HanteiScript = Gameover_hantei.GetComponent<Gameover_hantei>();
    }
    // Update is called once per frame
    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (pauseUIInstance == null)
			{
				stop = true;
				pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
				Time.timeScale = 0f;
			}
			else
			{
				stop = false;
				Destroy(pauseUIInstance);
				Time.timeScale = 1f;
			}
		}
		if (pauseUIInstance != null && Clear_HanteiScript.cl == true)
        {
			Destroy(pauseUIInstance);
		}
		if (pauseUIInstance != null && gameover_HanteiScript.Ga == true)
		{
			Destroy(pauseUIInstance);
		}
	}
}