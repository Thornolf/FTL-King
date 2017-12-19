using System;
using System.Collections.Generic;
using UnityEngine;

// {"Name":"Sword","Info":"It is really sharp","Stats":{"Strengh":1,"Dexterity":1,"Constitution":1,"Intelligence":1,"Widsom":1,"Charisma":1,"Protection":7}}

namespace Script
{
    [System.Serializable]
    public class Item
    {
        public String Name;
        public String Info;
        public Statistic Stats;
        public eTypeItem TypeItem { get; set; }
        public Money Price { get; set; }
        public WeightStat Weight { get; set; }
        
        
        //TODO Add a prop sprite for the futur
        
        public Item()
        {
            Name = "Empty";
            Info = "There is nothing.";
            Price = new Money(0);
            TypeItem = eTypeItem.Other;
            Stats = new Statistic();
            Weight = new WeightStat();
        }
        
        public Item(String newName, String newInfo, WeightStat newWeight, Money newPrice, eTypeItem newTypeItem)
        {
            Name = newName;
            Info = newInfo;
            Price = newPrice;
            TypeItem = newTypeItem;
            Stats = new Statistic();
            Weight = newWeight;
        }
        
        public Item(String newName, String newInfo, Statistic newStats, WeightStat newWeight, Money newPrice, eTypeItem newTypeItem)
        {
            Name = newName;
            Info = newInfo;
            Stats = newStats;
            Price = newPrice;
            TypeItem = newTypeItem;
            Weight = newWeight;
        }
        public void Dump()
        {
            Debug.Log("--- --- --- DEBUG ITEM MODE --- --- ---");
            Debug.Log("Name : " + Name);
            Debug.Log("Info : " + Info);
            Price.Dump();
            Debug.Log("Type Item : " + TypeItem);
            Stats.Dump();
            Weight.Dump();
            Debug.Log("--- --- --- --- --- --- --- --- --- --- ");
            
        }
    }
}