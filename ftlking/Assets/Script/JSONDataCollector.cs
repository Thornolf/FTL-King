using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Script;

namespace Script
{
    public class JSONDataCollector //TODO Amélioré le DRY de la classe
    {
        public String ItemTablesJsonName { get; set; }
        public String NorseNameJsonName { get; set; }
        /*
            ItemTablesJsonName = "TableItems.json";
            NorseNameJsonName = "norseName.json";
        */
        
        public T FillTable<T>(String gameDataFileName)
        {
            string filePath = Path.Combine(Application.persistentDataPath, gameDataFileName);
            T loadedData;
            Debug.Log(filePath);
            if (File.Exists(filePath))
            {
                string dataAsJson = File.ReadAllText(filePath);
                loadedData = JsonConvert.DeserializeObject<T>(dataAsJson);
            }
            else
            {
                loadedData = default(T);
                loadedData = Activator.CreateInstance<T>();
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