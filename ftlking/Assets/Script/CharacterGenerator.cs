using System;
using UnityEditorInternal.VersionControl;

namespace Script
{
    public class CharacterGenerator
    {
        public JSONDataCollector Collector { get; set; }
        public ItemTables Tables { get; set; }
        public NameListed Names { get; set; }
        public String ListItems { get; set; }
        public String ListNames { get; set; }
        
        public CharacterGenerator()
        {
            ListItems = "TableItems.json";
            ListNames = "norseName.json";
            Collector = new JSONDataCollector();
            Tables= Collector.GetItemTables(ListItems);
            
            Names = new NameListed();
            JSONDataCollector j = new JSONDataCollector();

            Names = j.GetNorseName(ListNames);
            
        }

        public Character GenerateRandomCharacter()
        {
            Character c = new Character(Names.NameList[UnityEngine.Random.Range(0, Names.NameList.Count)], new Level().GenerateRandomLevel(), new HealthHuman(), new BodyInventory(), new Inventory().AddingRandomItems(UnityEngine.Random.Range(0, 10), Tables), new Statistic().GenerateRandomStatsForCharacter(), "Description", "PrefabName", new WeightStat().GenerateRandomWeight(70f, 100f), new Money().GenerateRandomMoney(0, 1000));
            return (c); //TODO Reste à implem un json pour la description et pour les names des prefab après ça je pense que c'est good
        }
    }
}