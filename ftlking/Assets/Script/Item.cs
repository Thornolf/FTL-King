﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Item
    {
        public String Name { get; set; }
        public String Info { get; set; }
        public Statistic Stats { get; set; }
        public Inventory Invent { get; set; } //TODO Attention l'inventory dans l'item dans l'inventory etc.
        public Double Weight { get; set; } //TODO Trouver un moyen de fix le probleme de recursivité de l'inventory dans l'item (Héritage ?)
        
        
        //TODO Add a prop sprite for the futur
        
        public Item()
        {
            Name = "Empty";
            Info = "There is nothing.";
            Stats = new Statistic();
            Invent = new Inventory();
        }

        public Item(String newName, String newInfo)
        {
            Name = newName;
            Info = newInfo;
            Stats = new Statistic();
            Invent = new Inventory();
        }
        public Item(String newName, String newInfo, Statistic newStats)
        {
            Name = newName;
            Info = newInfo;
            Stats = newStats;
            Invent = new Inventory();
        }
    }
}