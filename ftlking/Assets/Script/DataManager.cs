using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class DataManager : MonoBehaviour {
	
	private GameManager gameManager = GameManager.Instance;
	
	// Use this for initialization
	void Start ()
	{
		Debug.Log("Name : " + gameManager.ActualPlayer.MainCharacter.Name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
