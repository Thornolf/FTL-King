using System;
using System.Collections;
using System.Collections.Generic;

namespace Script
{
    public class Inventory
    {
        public Dictionary<int, Item> Inv = new Dictionary<int, Item>();
        public Double Weight { get; set; } //TODO Get le weight en récursif sur chaque item

        public void AddAnItem(int newId, Item newItem)
        {
            Inv.Add(newId, newItem);
        }
    }
}