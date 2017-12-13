using System;
using UnityEngine;

namespace Script
{
    public class WeightStat
    {
        public Double Weight { get; set; }
        
        public WeightStat()
        {
            Weight = 0f;
        }

        public WeightStat(Double newWeight)
        {
            Weight = newWeight;
        }

        public WeightStat GenerateRandomWeight(float min, float max)
        {
            Weight = (Double)UnityEngine.Random.Range(min, max);
            return (this);
        }

        public void Dump()
        {
            Debug.Log("--- --- --- Weight DEBUG MODE --- --- ---");
            Debug.Log("Weight : " + Weight);
            Debug.Log("--- --- --- --- --- --- --- --- --- --- --- ");
        }
    }
}