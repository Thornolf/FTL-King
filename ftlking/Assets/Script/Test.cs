using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;


/*
public enum eTypeItem
{
	Weapon = 0,
	Equipement = 1,
	Container = 2,
	Other = 3
}

public class Statistic
{
	public int Strengh;
	public int Dexterity;
	public int Constitution;
	public int Intelligence;
	public int Widsom;
	public int Charisma;
	public int Protection;
}

public class WeightStat
{
	public Double Weight { get; set; }
}

public class Inventory
{
	public Dictionary<int, Item> Inv
	public WeightStat Weight { get; set; }
}

public class Item
{
	public String Name = "Sword";
	public String Info = "It is really sharp";
	public Statistic Stats = new Statistic();
	public eTypeItem TypeItem = eTypeItem.Weapon;
	public int Price = 0;
	public Inventory Invent = new Inventory();
	public WeightStat Weight = new WeightStat();
}
*/

public class Test : MonoBehaviour {

	void Start ()
	{	
		/*
		Character c = new Character("Robert", new Level().GenerateRandomLevel(), new HealthHuman(), new BodyInventory(), new Statistic().GenerateRandomStatsForCharacter(), "Description", this.gameObject, new WeightStat().GenerateRandomWeight(70f, 100f), new Money().GenerateRandomMoney(0, 1000));
		c.Dump();
		*/
		JSONDataCollector j = new JSONDataCollector();
		ItemTables t = j.GetItemTables("TableItems.json");
		t.Dump();

	} 
}
