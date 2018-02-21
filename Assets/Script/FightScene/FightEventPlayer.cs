using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightEventPlayer : MonoBehaviour {

	public Vector3 moveDestination;
	public float movespeed = 10.0f;

	void Awake() {
		moveDestination = transform.position;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveDestination.y = 0.6f;
		colorTile ();
	}

	public void moveUpdate() {
		if (Vector3.Distance (moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * movespeed * Time.deltaTime;

			if (Vector3.Distance (moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
			}
		}
	}

	void OnMouseDown()
	{
		
	}

	public void colorTile()
	{
		var mapInstance = MapGenerator.instance;
		var pSelected = mapInstance.players [0];
		int indexTile = 0;
		Tile rightTile;

		foreach (List<Tile> tilesX in mapInstance.map) {
			indexTile = 0;
			foreach (Tile tile in tilesX) {
				if (Mathf.Approximately (pSelected.transform.position.x, tile.transform.position.x) && Mathf.Approximately (pSelected.transform.position.z, tile.transform.position.z)) {
					rightTile = tilesX[indexTile + 1];
					rightTile.GetComponent<Renderer> ().material.color = Color.magenta;
				}
				indexTile++;
			}
		}
	}
}
