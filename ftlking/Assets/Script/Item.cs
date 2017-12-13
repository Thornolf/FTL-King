using System;
using System.Collections.Generic;
using UnityEngine;

// {"Name":"Sword","Info":"It is really sharp","Stats":{"Strengh":1,"Dexterity":1,"Constitution":1,"Intelligence":1,"Widsom":1,"Charisma":1,"Protection":7}}

namespace Script
{
    //[System.Serializable]
    public class Item
    {
        public String Name;
        public String Info;
        public Statistic Stats;
        public int Price { get; set; }
        public Inventory Invent { get; set; }
        public WeightStat Weight { get; set; }
        
        
        //TODO Add a prop sprite for the futur
        
        public Item()
        {
            Name = "Empty";
            Info = "There is nothing.";
            Stats = new Statistic();
            Invent = new Inventory();
            Weight = new WeightStat();
        }
        
        public Item(String newName, String newInfo, WeightStat newWeight)
        {
            Name = newName;
            Info = newInfo;
            Stats = new Statistic();
            Invent = new Inventory();
            Weight = newWeight;
        }
        
        public Item(String newName, String newInfo, Statistic newStats, WeightStat newWeight)
        {
            Name = newName;
            Info = newInfo;
            Stats = newStats;
            Invent = new Inventory();
            Weight = newWeight;
        }
        public void Dump()
        {
            Debug.Log("--- --- --- DEBUG ITEM MODE --- --- ---");
            Debug.Log("Name : " + Name);
            Debug.Log("Info : " + Info);
            Stats.Dump();
            Invent.Dump();
            Weight.Dump();
            Debug.Log("--- --- --- --- --- --- --- --- --- --- ");
            
        }
    }
}