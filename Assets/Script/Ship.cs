﻿using System;
using System.Security;
using DefaultNamespace;
using UnityEngine;

namespace Script
{
    public class Ship
    {
        public String Name { get; set; }
        public Health Hp { get; set; }
        public Inventory ShipInv { get; set; }
        public Seats SeatsShip { get; set; }
        public WeightStat Weight { get; set; } //TODO Add getter with the weight of the shipInv + All characters
        public MyVector3 Position { get; set; }

        public Ship()
        {
            Name = "Starfullah";
            Hp = new Health();
            ShipInv = new Inventory();
            SeatsShip = new Seats();
            Weight = new WeightStat(100f);
            Position = new MyVector3(0f, 0f, 0f);
        }
    }
}