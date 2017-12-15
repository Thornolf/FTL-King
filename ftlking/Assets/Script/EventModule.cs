using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class EventModule
    {
        public List<Character> Protagonist { get; set; }
        public Player ActualPlayer { get; set; }
        public GameObject DialogBox { get; set; }

        public EventModule()
        {
            Protagonist = new List<Character>();
            ActualPlayer = new Player();
        }
    }
}