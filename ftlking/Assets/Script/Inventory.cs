using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace Script
{
    public class Inventory
    {
        public List<Item> Inv { get; set; }
        public WeightStat Weight { get; set; } //TODO Get le weight en récursif sur chaque item

        public Inventory()
        {
            Inv = new List<Item>();
            Weight = new WeightStat();
        }

        public Inventory AddingRandomItems(int numberItems, ItemTables t)
        {
            for (int i = 0; i < numberItems; i++)
            {
                Inv.Add(t.Equipement[UnityEngine.Random.Range(0, t.Equipement.Count)]);   
            }
            return (this);
        }
        public void Dump()
        {
            if (Inv.Count > 0)
            {
                foreach (var vItem in Inv)
                {
                    vItem.Dump();
                }
            }
            else
            {
                Debug.Log("The inventory is empty.");
            }
        }
    }
}