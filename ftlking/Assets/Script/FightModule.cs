using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script
{
	public class FightModule : EventModule
	{
		private CharacterGenerator Generator;
		private List<Character> Ennemies;

		public FightModule()
		{
		}

		public void Fight()
		{
			GenerateEnemies ();
			//DumpEnnemies ();
			if (gameManager.ActualPlayer.Company.Count < Ennemies.Count)
				Defeat ();
			else 
				Victory ();
		}
		void Start() {
			Generator = new CharacterGenerator ();
			Ennemies = new List<Character> ();
		}

		private void Victory()
		{
			gameManager.ActualPlayer.MainCharacter.CoinsMoney.Coins += 100;
			Debug.Log ("Victory");
		}

		private void Defeat()
		{
			gameManager.ActualPlayer.MainCharacter.CoinsMoney.Coins -= gameManager.ActualPlayer.MainCharacter.CoinsMoney.Coins * 30 / 100;
			Debug.Log ("Defeat");
		}

		private void GenerateEnemies()
		{
			int size = 1 + UnityEngine.Random.Range (0, 10);

			for (int i = 0; i < size; i++)
			{
				Ennemies.Add(Generator.GenerateRandomCharacter());
			}
		}

		public void Positive()
		{
			Fight();
			StopFighting();
		}

		public void Negative()
		{
			StopFighting();
		}

		private void StopFighting()
		{
			SceneManager.LoadScene("MainLevel");
		}
		
		public void DumpEnnemies()
		{
			Debug.Log ("!!!!!!!!! FIGHTING INFO !!!!!!!!!!");
			Debug.Log ("Size of the squad -----> " + Ennemies.Count);
			foreach (Character c in Ennemies)
			{
				c.Dump();
			}
		}
	}
}
