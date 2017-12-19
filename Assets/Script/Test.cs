using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;


public class Test : MonoBehaviour
{
	//private GameManager g = GameManager.Instance;
	void Start ()
	{
		/*
		GameManager g = new GameManager();
		string output = JsonConvert.SerializeObject(g.ActualPlayer.MainCharacter);
		Debug.Log(output);
		output = JsonConvert.SerializeObject(g.ActualPlayer.PlayerhShip);
		Debug.Log(output);
		output = JsonConvert.SerializeObject(g.ActualPlayer.Company);
		Debug.Log(output);
		
		
		SaveGame s = new SaveGame();
		s.Saving<Character>(g.ActualPlayer.MainCharacter, "MainCharacter");
		s.Saving<Ship>(g.ActualPlayer.PlayerhShip, "PlayerShip");
		s.Saving<List<Character>>(g.ActualPlayer.Company, "Company");
		*/
		PlayerPrefs.DeleteAll();
	}
}
