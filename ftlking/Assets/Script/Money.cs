using System;
using UnityEngine;

namespace Script
{
    public class Money
    {
        public int Coins { get; set; }

        public Money()
        {
            Coins = 0;
        }

        public Money GenerateRandomMoney(int min, int max)
        {
            Coins = UnityEngine.Random.Range(min, max);
            return (this);
        }

        public void Dump()
        {
            Debug.Log("--- --- MONEY DEBUG MODE --- ---");
            Debug.Log("Coins : " + Coins);
            Debug.Log("--- --- --- --- --- --- --- --- ---");
        }
    }
}