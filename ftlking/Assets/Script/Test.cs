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
	void Start ()
	{
		ItemTables t = new ItemTables();
		
		JSONDataCollector j = new JSONDataCollector();

		t = j.FillTable<ItemTables>("TableItems.json");
		foreach (var vItem in t.AllItems)
		{
			vItem.Dump();
		}
	}
	
	public void OnMouseDown()
	{
//		SceneManager.LoadScene("EventTrade");
	}
}
