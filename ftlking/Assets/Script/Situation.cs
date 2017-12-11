using System.Configuration;
using UnityEngine;

namespace Script
{
    public class Situation
    {
        public int Id { get; set; }
        public EventType e_EventType { get; set; }
        public GameObject GameObjectEvent { get; set; }
              
        //TODO Gérer l'appel de chaque situation qui se fera sur le canvas

        public Situation(int newId, EventType newEventType, GameObject newGameObjectEvent)
        {
            Id = newId;
            e_EventType = newEventType;
            GameObjectEvent = newGameObjectEvent;
        }
    }
}