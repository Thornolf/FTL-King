using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class BodyInventory
    {
        public Dictionary<String, Item> BodyInvent = new Dictionary<String, Item>();
        public WeightStat Weight { get; set; } //TODO Foreach in the inventory on all weight of each item

        public BodyInventory()
        {
            Item i = new Item();
            Weight = new WeightStat();
            
            BodyInvent.Add("Head", i);
            BodyInvent.Add("Torso", i);
            BodyInvent.Add("Left Shoulder", i);
            BodyInvent.Add("Right Shoulder", i);
            BodyInvent.Add("Left Arm", i);
            BodyInvent.Add("Right Arm", i);
            BodyInvent.Add("Left Hand", i);
            BodyInvent.Add("Right Hand", i);
            BodyInvent.Add("Belt", i);
            BodyInvent.Add("Left Leg", i);
            BodyInvent.Add("Right Leg", i);
            BodyInvent.Add("Left Foot", i);
            BodyInvent.Add("Right Foot", i);
            BodyInvent.Add("Back1", i);
            BodyInvent.Add("Back2", i);
        }
        
        public void Dump() 
        {
            Debug.Log("--- --- DEBUG BODY INVENTORY MODE --- ---");
            foreach (var bodyInvent in BodyInvent)
            {
                Debug.Log("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                Debug.Log(" Emplacement [" + bodyInvent.Key + "] : ");
                //bodyInvent.Value.Dump();
                Debug.Log("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            }
            Debug.Log("--- --- --- --- --- --- --- --- --- --- ---");
        }
    }
    
    
    /*
     * Body Part list:
     * HEAD
     * TORSO
     * LEFT SHOULDER
     * RIGHT SHOULDER
     * LEFT ARM
     * RIGHT ARM
     * LEFT HAND
     * RIGHT HAND
     * BELT
     * LEFT LEG
     * RIGHT LEG
     * LEFT FOOT
     * RIGHT FOOT
     * BACK1
     * BACK2
     *
     * Why multiple back ? Because you can wore a backpack and a big 2h axe in the back
     */
}