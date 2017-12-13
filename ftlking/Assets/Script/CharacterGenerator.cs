using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
	public class CharacterGenerator
	{
		public String Name { get; set; }
		public Level Lvl { get; set; }
		public HealthHuman Hp { get; set; }
		public Inventory BagInventory { get; set; }
		public BodyInventory Body { get; set; }
		public Statistic Stats { get; set; }
		public String Description { get; set; }
		public GameObject CharacterEntity { get; set; }
		public Double Weight { get; set; }
		public List<String> NameList { get; set; }
		public List<String> DescriptionList { get; set; }
		public Character Char { get; set; }

		public CharacterGenerator()
		{
			// Initilisation of list
			InitNameList ();
			InitDescriptionList ();
			//Random for name
			System.Random rnd = new System.Random();
			Name = NameList[rnd.Next(NameList.Count)];
			//Setting other attribute
			Lvl = new Level();
			Hp = new HealthHuman();
			BagInventory = new Inventory();
			Body = new BodyInventory();
			Stats = new Statistic();
			Stats.GenerateRandomStatsForCharacter();
			Weight = 70f;
			//Random for Description
			rnd = new System.Random();
			Description = DescriptionList[rnd.Next(DescriptionList.Count)];
			//Ssetting up Character Attribute
			Char = new Character (Name, Lvl, Hp, BagInventory, Stats, Description, null, Weight);
			DebugGeneration();
		}
			
		public void InitNameList()
		{
			NameList = new List<string> ();
			NameList.Add ("Pascal");
			NameList.Add ("Eugène");
			NameList.Add ("Heimdall");
			NameList.Add ("Balgr");
			NameList.Add ("Fenrir");
			NameList.Add ("Jormundgar");
			NameList.Add ("Einerihar");
			NameList.Add ("Midgard");
		}

		public void InitDescriptionList()
		{
			DescriptionList = new List<string> ();
			DescriptionList.Add ("Il adore l'odeur du sang");
			DescriptionList.Add ("La chasse n'a plus de secret pour lui");
			DescriptionList.Add ("Pillage et rapine !!!!");
			DescriptionList.Add ("Son bateau est sa deuxième maison");
			DescriptionList.Add ("On l'appelle l'ovni, BANG BANG");
		}

		public void DebugGeneration()
		{
			Debug.Log ("Name " + Name);
			Debug.Log ("Description " + Description);
			Char.Stats.DebugStats();
		}
	}
}