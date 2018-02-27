using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public Vector2 GridPosition = Vector2.zero;

	private Color startcolor;
	private MapGenerator map = MapGenerator.instance;
	private bool GoMove = false;
	public bool InRange = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseEnter() {
		startcolor = GetComponent<Renderer> ().material.color;
		Debug.Log ("Ennemies nb : " + map.ennemies.Count);
		foreach (FightEventPlayer p in map.ennemies) {
			if (Mathf.Approximately (transform.position.x, p.transform.position.x) && Mathf.Approximately (transform.position.z, p.transform.position.z)) {
				GetComponent<Renderer> ().material.color = Color.red;
				GoMove = false;
			} else {
				GetComponent<Renderer>().material.color = Color.green;
				GoMove = true;
			}
		}
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = startcolor;
	}
		
	void OnMouseDown() {
		FightEventPlayer selectedPlayer = null;

		foreach (FightEventPlayer p in map.players) {
			if (Mathf.Approximately (transform.position.x, p.transform.position.x) && Mathf.Approximately (transform.position.z, p.transform.position.z)) {
				selectedPlayer = p;
			}
		}
		if (selectedPlayer != null && map.selectedPlayer == null) {
			map.selectedPlayer = selectedPlayer;
			map.selectedPlayer.changeColorOnSelect ();
		} else if (map.selectedPlayer != null && selectedPlayer != null) {
			map.selectedPlayer.changeColorOnDeselect ();
			map.selectedPlayer = null;
		}
		else if (GoMove == true && map.selectedPlayer != null) {
			map.moveCurrentPlayer (this);
		}
	}
}
