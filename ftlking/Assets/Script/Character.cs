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
		public GameObject characterEntity { get; set; }
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

		public Character(String newName)
		{
		}
	}
}
