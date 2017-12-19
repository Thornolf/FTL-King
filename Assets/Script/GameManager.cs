using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
	public class GameManager : MonoBehaviour
	{
		public Player ActualPlayer { get; set; }
		
		public static GameManager Instance {
			get;
			set;
		}

		public GameManager()
		{
			ActualPlayer = new Player();
		}
		
		void Awake () {
			DontDestroyOnLoad (transform.gameObject);
			Instance = this;
		}
		
		void Start()
		{
			ActualPlayer = gameObject.AddComponent<Player>();
			ActualPlayer.MainCharacter = new Character("Thornolf Bjarnulf");
			SceneManager.LoadScene("Menu");
		}
	}
}
