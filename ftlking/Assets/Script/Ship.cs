using System;
using System.Security;
using UnityEngine;

namespace Script
{
    public class Ship
    {
        public String Name { get; set; }
        public Health Hp { get; set; }
        public Inventory ShipInv { get; set; }
        public Seats SeatsShip { get; set; }
        public WeightStat Weight { get; set; } //TODO Add with the weight of the shipInv + All characters
        public Vector3 Position { get; set; }

        public Ship()
        {
            Name = "Starfullah";
            Hp = new Health();
            ShipInv = new Inventory();
            SeatsShip = new Seats();
            Weight = new WeightStat(100f);
            Position = new Vector3(0f, 0f, 0f);
        }
    }
}