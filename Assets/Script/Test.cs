using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;

public abstract class BaseClass  {

	private List<BaseClass> children = new List<BaseClass>();

	public void AddChild(BaseClass child)
	{
		this.children.Add(child);
	}

	protected virtual void DoMoreStuff(){
		Debug.Log("Doing more stuff");
	}

	public void DisplayChildren()
	{
		foreach (var vChild in children)
		{
			vChild.DoMoreStuff();
		}
	}
	public void DoSomething(int i){
		children[i].DoMoreStuff();
	}
}

public class Taverne : BaseClass {

	protected override void DoMoreStuff(){
		Debug.Log("Hi and welcome to the tavern !");
	}

}

public class Ferme : BaseClass {

	protected override void DoMoreStuff(){
		Debug.Log("This is the farm house. Do you need any food ?");
	}
}

public class Test : MonoBehaviour
{
	//private GameManager g = GameManager.Instance;
	
	void Start ()
	{
		BaseClass testList = new Taverne();
		testList.AddChild(new Taverne()); 
		testList.AddChild(new Ferme()); 
		testList.AddChild(new Taverne()); 
		testList.AddChild(new Ferme()); 
		
		testList.DisplayChildren();
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
		
		
		//PlayerPrefs.DeleteAll();
	}
}
