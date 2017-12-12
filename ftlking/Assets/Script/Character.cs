using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
	public class Character
	{
		public String Name { get; set; }
		public Level Lvl { get; set; }
		public HealthHuman Hp { get; set; }
		public Inventory BagInventory { get; set; }
		public BodyInventory Body { get; set; }
		public Statistic Stats { get; set; }
		public String Descrition { get; set; }
		public GameObject CharacterEntity { get; set; }
		public Double Weight { get; set; }
	
		public Character()
		{
			Name = "Maurice";
			Lvl = new Level();
			Hp = new HealthHuman();
			BagInventory = new Inventory();
			Body = new BodyInventory();
			Stats = new Statistic();
			Weight = 70f;
		}

		public Character(String newName, Double newWeight)
		{
			Name = newName;
			Weight = newWeight;
		}
		
		public Character(String newName, Level newLvl, HealthHuman newHp, Inventory newBagInventory, Statistic newStats, String newDescription, GameObject newCharacterEntity, Double newWeight)
		{
			Name = newName;
			Lvl = newLvl;
			Hp = newHp;
			BagInventory = newBagInventory;
			Stats = newStats;
			Descrition = newDescription;
			CharacterEntity = newCharacterEntity;
			Weight = newWeight;
		}
	}
}
