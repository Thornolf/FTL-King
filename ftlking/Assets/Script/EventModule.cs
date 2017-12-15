using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class EventModule
    {
        public Player ActualPlayer { get; set; }
        public GameObject DialogBox { get; set; }

        public EventModule()
        {
            ActualPlayer = new Player();
        }
    }
}