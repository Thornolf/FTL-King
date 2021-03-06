﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Script
{
    public class ItemTables
    {
        public List<Item> Weapon { get; set; }   
        public List<Item> Equipement { get; set; }
        public List<Item> Container { get; set; } 
        public List<Item> Other { get; set; }

        public List<Item> AllItems 
        {
            get { return Weapon.Concat(Equipement).Concat(Container).Concat(Other).ToList(); }
            set { }
        }

        public ItemTables()
        {
            Weapon = new List<Item>();
            Equipement = new List<Item>();
            Container= new List<Item>();
            Other = new List<Item>();
        }

        public void Dump()
        {
            foreach (var vWeapon in Weapon)
            {
                vWeapon.Dump();
            }
        }
    }
}