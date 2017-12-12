using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Script;

public class Test : MonoBehaviour {

	void Start ()
	{
		int a = 34;
		
		List<int> l = new List<int>();
		
		for (int i = 0; i < 6; i++)
		{
			if (i == 6 - 1)
				l.Add(a);
			else
			{
				int j = UnityEngine.Random.Range(0, a);
				a -= j;
				l.Add(j);
			}
		}
		
		foreach (var v in l)
		{
			Debug.Log(v);

		}
		/*
		Character c = new Character();
		Item i = new Item("Sword", "It is really sharp.");
		Item a = new Item("Axe", "SWING IT.");
		c.Body.BodyInvent["Belt"].Invent.AddAnItem(1, i);
		c.Body.BodyInvent["Belt"].Invent.AddAnItem(2, a);
		foreach (var it in c.Body.BodyInvent["Belt"].Invent.Inv)
		{
			Debug.Log(it.Value.Name);
		}*/
	}

	void Update()
	{
	}
}
