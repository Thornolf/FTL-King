using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	private GameManager gameManager = GameManager.Instance;
	
	void Start () {
	}
	
	void Update () {
		
	}

	public void StartGame()
	{
		SceneManager.LoadScene("MainLevel");
		Debug.Log("Start a game");
	}

	public void LoadedGame()
	{
		SaveGame s = gameObject.AddComponent<SaveGame>();
		gameManager.ActualPlayer.MainCharacter = s.ChooseLoad<Character>("MainCharacter");
		gameManager.ActualPlayer.PlayerhShip = s.ChooseLoad<Ship>("PlayerShip");
		gameManager.ActualPlayer.Company = s.ChooseLoad<List<Character>>("Company");
		
		Debug.Log("Name : " + gameManager.ActualPlayer.MainCharacter.Name);
		SceneManager.LoadScene("MainLevel");
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
}
