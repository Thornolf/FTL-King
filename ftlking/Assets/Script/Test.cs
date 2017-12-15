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
		Character c = new Character ();
		CharacterGenerator g = new CharacterGenerator();
		List<Character> l = new List<Character>();
		for (int i = 0; i < 6; i++)
		{
			l.Add(g.GenerateRandomCharacter());
		}

		Player p = new Player (c, l);
		FightModule f = new FightModule();
		f.ActualPlayer = p;
		f.Fight ();
	} 
}
