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
		public Inventory Inv { get; set; }
		public BodyInventory Body { get; set; }
		public Statistic Stats { get; set; }
		public String Descrition { get; set; }
		public GameObject CharacterEntity { get; set; }
		public WeightStat Weight { get; set; }
		public Money CoinsMoney { get; set; }
	
		public Character()
		{
			Name = "Maurice";
			Lvl = new Level();
			Hp = new HealthHuman();
			Body = new BodyInventory();
			Inv = new Inventory();
			Stats = new Statistic();
			Weight = new WeightStat();
			CoinsMoney = new Money();
		}

		public Character(String newName, WeightStat newWeight)
		{
			Name = newName;
			Weight = newWeight;
		}
		
		public Character(String newName, Level newLvl, HealthHuman newHp, BodyInventory newBodyInventory, Inventory newInv, Statistic newStats, String newDescription, GameObject newCharacterEntity, WeightStat newWeight, Money newCoinsMoney)
		{
			Name = newName;
			Lvl = newLvl;
			Hp = newHp;
			Body = newBodyInventory;
			Inv = newInv;
			Stats = newStats;
			Descrition = newDescription;
			CharacterEntity = newCharacterEntity;
			Weight = newWeight;
			CoinsMoney = newCoinsMoney;
		}

		public void Dump()
		{
			Debug.Log("Name : " + Name);
			Lvl.Dump();
			Hp.Dump();
			Body.Dump();
			Stats.Dump();
			Debug.Log("Description : " + Descrition);
			Inv.Dump();
			Weight.Dump();
			CoinsMoney.Dump();
		}
	}
}
