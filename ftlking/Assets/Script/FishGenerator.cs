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
			species.Add("Codfish");
			descriptions.Add ("It looks good.");
			weight = new WeightStat ().GenerateRandomWeight(0.5f, 20.0f);
		}

		public Item	FishCreate()
		{
			Item fishOut = new Item("Codfish",	"Good taste.", weight, new Money(20), eTypeItem.Other);
			return (fishOut);
		}

		public void Dump()
		{
			FishGenerator genTest = new FishGenerator ();
			Item test = genTest.FishCreate();
			Debug.Log ("---- Debug Fish ----");
			Debug.Log ("Name : " + test.Name);
			Debug.Log ("info : " + test.Info);
			Debug.Log ("Weight :" + test.Weight);
			test.Stats.Dump();
		}
	}
}
