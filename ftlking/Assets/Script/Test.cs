using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;
using UnityEngine.SceneManagement;


public class Test : MonoBehaviour {
	
	public Player player = new Player();
	void Start ()
	{
	} 
	public void OnMouseDown()
	{
		SceneManager.LoadScene("EventTrade");
	}
}
