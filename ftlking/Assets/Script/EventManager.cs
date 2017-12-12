using System.Collections.Generic;
using System.Configuration;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class EventManager
    {
        public int Id { get; set; }
        public int NumberCharacter { get; set; }
        public eEventType e_EventType { get; set; }
        public eEventPlaces e_EventPlaces { get; set; }
        public List<Character> CharacterList { get; set; }

        public EventManager(int newId, eEventType newEventType, eEventPlaces newEventPlaces, int newNumberCharacter)
        {
            CharacterList = new List<Character>();
            Id = newId;
            e_EventType = newEventType;
            e_EventPlaces = newEventPlaces;
            NumberCharacter = newNumberCharacter;
            for (int i = 0; i < NumberCharacter; i++)
            {
                Character c = new Character();
                CharacterList.Add(c);
            }
        }
        
        
        public EventManager(int newId, eEventType newEventType, eEventPlaces newEventPlaces)
        {
            CharacterList = new List<Character>();
            Id = newId;
            e_EventType = newEventType;
            e_EventPlaces = newEventPlaces;
            NumberCharacter = UnityEngine.Random.Range(0, 10);
            for (int i = 0; i < NumberCharacter; i++)
            {
                Character c = new Character();
                CharacterList.Add(c);
            }
        }
    }
}