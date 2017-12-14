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
            Item p = new Item();
            Inv = new List<Item>();
            Weight = new WeightStat();
            Inv.Add(p);
        }
        public void AddAnItem(Item newItem)
        {
            Inv.Add(newItem);
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