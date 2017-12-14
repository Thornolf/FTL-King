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
		CharacterGenerator g = new CharacterGenerator();
		
		List<Character> l = new List<Character>();

		for (int i = 0; i < 10; i++)
		{
			l.Add(g.GenerateRandomCharacter());
		}

		foreach (var vCharacter in l)
		{
			vCharacter.Dump();
		}
	} 
}
