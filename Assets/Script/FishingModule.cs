using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script 
{
	public class FishingModule : EventModule 
	{
		public Text	text;
		private Item fish = new FishGenerator ().FishCreate ();

		void Start()
		{
			FishGenerator f = new FishGenerator();
			//fish = new Item();
			//fish = f.FishCreate();
			
			//fish.Dump ();
			text.text = "Hi ! Do you want to try to catch some FISH ?!";
		}

		public void Positive()
		{
			gameManager.ActualPlayer.MainCharacter.Inv.Invent.Add (fish);
			text.text = "OK you're fishing a " + fish.Name;
			StopFishing();
		}

		public void Negative()
		{
			Debug.Log ("Nope");
			StopFishing();
		}

		public void StopFishing()
		{
			SceneManager.LoadScene ("MainLevel");
		}
	}
}
