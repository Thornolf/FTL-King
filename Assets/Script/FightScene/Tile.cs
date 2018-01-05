using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public Vector2 GridPosition = Vector2.zero;

	private Color startcolor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseEnter() {
		startcolor = GetComponent<Renderer> ().material.color;
		foreach (FightEventPlayer p in MapGenerator.instance.players) {
			if (Mathf.Approximately (transform.position.x, p.transform.position.x) && Mathf.Approximately (transform.position.z, p.transform.position.z)) {
				GetComponent<Renderer> ().material.color = Color.red;
			} else {
				GetComponent<Renderer>().material.color = Color.green;
			}
		}
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = startcolor;
	}

	void OnMouseDown() {
		foreach (FightEventPlayer p in MapGenerator.instance.players) {
			if (!(Mathf.Approximately (transform.position.x, p.transform.position.x)) || !(Mathf.Approximately (transform.position.z, p.transform.position.z))) {
				MapGenerator.instance.moveCurrentPlayer (this);
			}
		}
	}
}
