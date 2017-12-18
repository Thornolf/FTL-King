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
	
		// Update is called once per frame
		void Update () {
		
		}
	}
}
