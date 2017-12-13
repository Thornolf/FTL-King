using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Inventory
    {
        public Dictionary<int, Item> Inv { get; set; }
        public WeightStat Weight { get; set; } //TODO Get le weight en récursif sur chaque item

        public Inventory()
        {
            Inv = new Dictionary<int, Item>();
            Weight = new WeightStat();
        }
        public void AddAnItem(int newId, Item newItem)
        {
            Inv.Add(newId, newItem);
        }

        public void Dump()
        {
            if (Inv.Count > 0)
            {
                foreach (var vItem in Inv)
                {
                    Debug.Log("Id : " + vItem.Key);
                    //vItem.Value.Dump();
                }
            }
            else
            {
                Debug.Log("The inventory is empty.");
            }
        }
    }
}