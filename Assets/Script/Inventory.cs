﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace Script
{
    public class Inventory
    {
        public List<Item> Invent { get; set; }
        public WeightStat Weight
        {
            get
            {
                Double tmp = 0;
                foreach (var vItem in Invent)
                {
                     tmp = vItem.Weight.Weight;
                }
                WeightStat w = new WeightStat(tmp);
                return (w);
            }
            set { }
        }

        public Inventory()
        {
            Invent = new List<Item>();
            Weight = new WeightStat();
        }

        public Inventory AddingRandomItems(int numberItems, ItemTables t)
        {
            for (int i = 0; i < numberItems; i++)
            {
                Invent.Add(t.Equipement[UnityEngine.Random.Range(0, t.Equipement.Count)]);   
            }
            return (this);
        }
        
        public void Dump()
        {
            if (Invent.Count > 0)
            {
                foreach (var vItem in Invent)
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