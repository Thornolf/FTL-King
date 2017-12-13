using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;



public class Test : MonoBehaviour {

	void Start ()
	{	
		/*
		Character c = new Character("Robert", new Level().GenerateRandomLevel(), new HealthHuman(), new BodyInventory(), new Statistic().GenerateRandomStatsForCharacter(), "Description", this.gameObject, new WeightStat().GenerateRandomWeight(70f, 100f), new Money().GenerateRandomMoney(0, 1000));
		c.Dump();
		*/
		LoadGameData();
		
	} 
	
	private string gameDataFileName = "allitems.json";
	
	private void LoadGameData()
	{
		// Path.Combine combines strings into a file path
		// Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
		string filePath = Path.Combine(Application.persistentDataPath, gameDataFileName);

		Debug.Log(filePath);
		if(File.Exists(filePath))
		{
			// Read the json from the file into a string
			string dataAsJson = File.ReadAllText(filePath);
			// Pass the json to JsonUtility, and tell it to create a GameData object from it
			Item loadedData = JsonConvert.DeserializeObject<Item>(dataAsJson);
		}
		else
		{
			Debug.LogError("Cannot load game data!");
		}
	}
	
	void Update()
	{
	}
}
