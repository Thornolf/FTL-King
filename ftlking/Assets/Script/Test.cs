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
	private GameManager g = GameManager.Instance;
	void Start ()
	{
		g.ActualPlayer.MainCharacter.Inv.Dump();
	}
	
	public void OnMouseDown()
	{
//		SceneManager.LoadScene("EventTrade");
	}
}
