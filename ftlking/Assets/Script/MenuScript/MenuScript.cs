using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame()
	{
		SceneManager.LoadScene("MainLevel");
		Debug.Log("Start a game");
	}

	public void StartNewGame()
	{
		Debug.Log("Start a new game");
	}

	public void SettingGame()
	{
		Debug.Log("Setting update");
	}
	public void Quit()
	{
		Application.Quit();
	}
	//public void 
}
