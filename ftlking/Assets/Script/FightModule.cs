using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
	public class FightModule : EventModule
	{
		private CharacterGenerator generator;
		private List<Character> ennemies;

		public FightModule()
		{
			generator = new CharacterGenerator ();
			ennemies = new List<Character> ();
		}

		public void Fight()
		{
			GenerateEnemies ();
			//DumpEnnemies ();
			if (ActualPlayer.Company.Count < ennemies.Count)
				Defeat ();
			else 
				Victory ();
		}

		private void Victory()
		{
			ActualPlayer.MainCharacter.CoinsMoney.Coins += 100;
			Debug.Log ("Victory");
		}

		private void Defeat()
		{
			ActualPlayer.MainCharacter.CoinsMoney.Coins -= ActualPlayer.MainCharacter.CoinsMoney.Coins * 30 / 100;
			Debug.Log ("Defeat");
		}

		private void GenerateEnemies()
		{
			int size = 1 + UnityEngine.Random.Range (0, 10);

			for (int i = 0; i < size; i++)
			{
				ennemies.Add(generator.GenerateRandomCharacter());
			}		
		}

		public void DumpEnnemies()
		{
			Debug.Log ("!!!!!!!!! FIGHTING INFO !!!!!!!!!!");
			Debug.Log ("Size of the squad -----> " + ennemies.Count);
			foreach (Character c in ennemies)
			{
				c.Dump();
			}
		}
	}
}
