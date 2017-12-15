using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;

namespace Script
{
    public class JSONDataCollector
    {
        public String ItemTablesJsonName { get; set; }
        public String NorseNameJsonName { get; set; }

        public JSONDataCollector()
        {
            ItemTablesJsonName = "TableItems.json";
            NorseNameJsonName = "norseName.json";
        }
        public ItemTables GetItemTables(String gameDataFileName)
        {
            // Path.Combine combines strings into a file path
            // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
            string filePath = Path.Combine(Application.persistentDataPath, gameDataFileName);
            ItemTables loadedData;
            Debug.Log(filePath);
            if (File.Exists(filePath))
            {
                // Read the json from the file into a string
                string dataAsJson = File.ReadAllText(filePath);
                // Pass the json to JsonUtility, and tell it to create a GameData object from it
                loadedData = JsonConvert.DeserializeObject<ItemTables>(dataAsJson);
            }
            else
            {
                loadedData = new ItemTables();
                Debug.LogError("Cannot load game data!");
            }
            return (loadedData);
        }
        
        public NameListed  GetNorseName(String gameDataFileName)
        {
            // Path.Combine combines strings into a file path
            // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
            string filePath = Path.Combine(Application.persistentDataPath, gameDataFileName);
            NameListed loadedData;
            Debug.Log(filePath);
            if (File.Exists(filePath))
            {
                // Read the json from the file into a string
                string dataAsJson = File.ReadAllText(filePath);
                // Pass the json to JsonUtility, and tell it to create a GameData object from it
                loadedData = JsonConvert.DeserializeObject<NameListed>(dataAsJson);
            }
            else
            {
                loadedData = new NameListed();
                Debug.LogError("Cannot load game data!");
            }
            return (loadedData);
        }

        private void SerializeData()
        {
            //string json = JsonConvert.SerializeObject(MyObject, Formatting.Indented);
            //return (json);
        }
    }
}