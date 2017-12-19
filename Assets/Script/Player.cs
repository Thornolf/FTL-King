using System;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Character MainCharacter { get; set; }
    public Ship PlayerhShip { get; set; }
    public List<Character> Company { get; set; }
    
    public Player()
    {
        //MainCharacter = new Character("Thornolf Bjarnulf", new Level().GenerateRandomLevel(), new HealthHuman(), new BodyInventory(), new
        PlayerhShip = new Ship();
        Company = new List<Character>();
        
    }

    public Player(String newName)
    {
        MainCharacter = new Character(newName, new Level().GenerateRandomLevel(), new HealthHuman(), new BodyInventory(), new Inventory(), new Statistic().GenerateRandomStatsForCharacter(), "Description", "PrefabName", new WeightStat().GenerateRandomWeight(70f, 100f), new Money().GenerateRandomMoney(100, 1000));
        PlayerhShip = new Ship();
        Company = new List<Character>();   
    }
    
	public Player(Character newMainCharacter, List<Character> newCompany)
	{
		MainCharacter = newMainCharacter;
		Company = newCompany;
	}

    public void Dump()
    {
        Debug.Log("--- --- --- PLAYER DEBUG MODE --- --- ---");
        Debug.Log(" MainCharacter : ");
        MainCharacter.Dump();
        foreach (var character in Company)
        {
            Debug.Log("_____________________");
            character.Dump();
            Debug.Log("_____________________");
            
        }
        Debug.Log("--- --- --- --- --- --- --- --- --- --- ---");
        
    }
}