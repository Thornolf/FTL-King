﻿using System;
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
		public String PrefabName { get; set; }
		public GameObject CharacterEntity { get; set; }
		public WeightStat Weight { get; set; } //TODO get the weight of the body inventory + invtory + character himself
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

		public Character(String newName)
		{
			Name = newName;
			Lvl = new Level().GenerateRandomLevel();
			Hp = new HealthHuman();
			Body = new BodyInventory();
			Inv = new Inventory();
			Stats = new Statistic().GenerateRandomStatsForCharacter();
			Descrition = "I was an adventurer like you but I took an arrow in the knee !";
			PrefabName = "PREFABNAME";
			Weight = new WeightStat().GenerateRandomWeight(70f, 100F);
			CoinsMoney = new Money().GenerateRandomMoney(100, 5000);
			
		}
		public Character(String newName, WeightStat newWeight)
		{
			Name = newName;
			Weight = newWeight;
		}
		
		
		public Character(String newName, Level newLvl, HealthHuman newHp, BodyInventory newBodyInventory, Inventory newInv, Statistic newStats, String newDescription, String newPrefabName, WeightStat newWeight, Money newCoinsMoney)
		{
			Name = newName;
			Lvl = newLvl;
			Hp = newHp;
			Body = newBodyInventory;
			Inv = newInv;
			Stats = newStats;
			Descrition = newDescription;
			PrefabName = newPrefabName;
			Weight = newWeight;
			CoinsMoney = newCoinsMoney;
		}
		
		public Character(String newName, Level newLvl, HealthHuman newHp, BodyInventory newBodyInventory, Inventory newInv, Statistic newStats, String newDescription, String newPrefabName, GameObject newCharacterEntity, WeightStat newWeight, Money newCoinsMoney)
		{
			Name = newName;
			Lvl = newLvl;
			Hp = newHp;
			Body = newBodyInventory;
			Inv = newInv;
			Stats = newStats;
			Descrition = newDescription;
			PrefabName = newPrefabName;
			CharacterEntity = newCharacterEntity;
			Weight = newWeight;
			CoinsMoney = newCoinsMoney;
		}

		public void Dump()
		{
			Debug.Log("Name : " + Name);
			Lvl.Dump();
			Hp.Dump();
			//Body.Dump();
			Stats.Dump();
			Debug.Log("Description : " + Descrition);
			Inv.Dump();
			Weight.Dump();
			CoinsMoney.Dump();
		}
	}
}
