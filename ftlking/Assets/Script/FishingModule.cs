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
			fish.Dump ();
		}

		public void Positive()
		{
			gameManager.ActualPlayer.MainCharacter.Inv.Invent.Add (fish);
			text.text = "OK you're fishing a " + fish.Name;
		}

		public void Negative()
		{
			Debug.Log ("Nope");
		}

		public void stop()
		{
			SceneManager.LoadScene ("MainLevel");
		}
	}
}
