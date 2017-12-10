using System;
using System.Security;

namespace Script
{
    public class Ship
    {
        public String Name { get; set; }
        public Health Hp { get; set; }
        public Inventory ShipInv { get; set; }
        public Seats SeatsShip { get; set; }
        public Double Weight { get; set; } //TODO Add with the weight of the shipInv
    }
}