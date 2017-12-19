using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
	public class FishGenerator
	{
		private List<string> species = new List<string>();
		private List<string> descriptions = new List<string>();
		private WeightStat weight;

		public FishGenerator()
		{
			species.InsertRange (species.Count, new List<string> {"CodFish", "Breaded fish", "Salmon"});
			descriptions.InsertRange (descriptions.Count, new List<string> {"Miam", "Good Taste", "Great"});
			weight = new WeightStat(1f);
		}

		public Item	FishCreate()
		{
			Item fishOut = new Item(species[0], descriptions[1],
				weight, new Money(20), eTypeItem.Other);
			return (fishOut);
		}

		public void Dump()
		{
			FishGenerator genTest = new FishGenerator ();
			Item test = genTest.FishCreate();
			Debug.Log ("---- Debug Fish ----");
			Debug.Log ("Name : " + test.Name);
			Debug.Log ("info : " + test.Info);
			test.Weight.Dump();
			test.Stats.Dump();
		}
	}
}
