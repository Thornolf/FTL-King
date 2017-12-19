using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Script;
using UnityEngine;

public class SaveGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public String SerializeSave<T>(T obj)
	{
		String json = JsonConvert.SerializeObject(obj);
		return (json);
	}
	
	public T DeserializeSave<T>(String dataJson)
	{
		T data = JsonConvert.DeserializeObject<T>(dataJson);
		return (data);
	}

	public void Saving<T>(T obj, String key)
	{
		String saveData = SerializeSave<T>(obj);
		PlayerPrefs.SetString(key, saveData);
	}

	public T Loading<T>(String saveFile)
	{
		String saveData = PlayerPrefs.GetString(saveFile);
		T obj = DeserializeSave<T>(saveData);
		return (obj);
	}

	public T ChooseLoad<T>(String saveName)
	{
		T obj = Loading<T>(saveName);
		return (obj);
	}
}
