using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInit : MonoBehaviour {

	private Player p = Player.Instance;
	// Use this for initialization
	void Start () {
		Debug.Log("Name of the actual scene is : " + SceneManager.GetActiveScene().name);
		Debug.Log(p.MainCharacter.Name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
