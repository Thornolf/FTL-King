using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public Vector2 GridPosition = Vector2.zero;

	private Color startcolor;
	private bool GoMove = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseEnter() {
		startcolor = GetComponent<Renderer> ().material.color;
		Debug.Log ("Ennemies nb : " + MapGenerator.instance.ennemies.Count);
		foreach (FightEventPlayer p in MapGenerator.instance.ennemies) {
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
		if (GoMove) {
			MapGenerator.instance.moveCurrentPlayer (this);
		}
	}
}
