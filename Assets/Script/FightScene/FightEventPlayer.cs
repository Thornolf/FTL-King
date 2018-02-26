using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightEventPlayer : MonoBehaviour {

	public Vector3 moveDestination;
	public float movespeed = 10.0f;
	public int movementpointLeft = 4;
	public bool movementDone = false;
	public bool attackDone = false;

	void Awake() {
		moveDestination = transform.position;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveDestination.y = 0.5f;
		if (Input.GetKeyDown("space"))
			resetColor ();	
	}
		
	public void moveUpdate(Tile tileDes) {
		moveDestination.x = tileDes.transform.position.x;
		moveDestination.z = tileDes.transform.position.z;
		if (Vector3.Distance (moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * movespeed * Time.deltaTime;

			if (Vector3.Distance (moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
				MapGenerator.instance.selectedPlayer = null;
				MapGenerator.instance.resetColor ();
			}
		}
	}

	public void colorMovementTile()
	{
		var depth = movementpointLeft;
		var mapInstance = MapGenerator.instance;
		var map = mapInstance.map;
		var pSelected = mapInstance.selectedPlayer;
		int indexTileX = 0;
		int indexTileY = 0;	
		Tile rightTile;

		foreach (List<Tile> tilesX in map) {
			foreach (Tile tile in tilesX) {
				
				if (Mathf.Approximately (pSelected.transform.position.x, tile.transform.position.x) && Mathf.Approximately (pSelected.transform.position.z, tile.transform.position.z)) {
					
					rightTile = map[indexTileX][indexTileY];
					colorIterate (depth, map, indexTileX, indexTileY - 1);
					colorIterate (depth, map, indexTileX + 1, indexTileY);
					colorIterate (depth, map, indexTileX, indexTileY + 1);
					colorIterate (depth, map, indexTileX - 1, indexTileY);
				}
				indexTileY++;
			}
			indexTileY = 0;
			indexTileX++;
		}
	}

	private void colorIterate(int depth, List<List<Tile>> map, int currentX, int currentY)
	{
		
		depth--;
		if (currentX >= 0 && currentY >= 0) {
			if (currentX < map.Count && currentY < map.Count) {
				if (isThereSomething (map, currentX, currentY) == true)
					map [currentX] [currentY].GetComponent<Renderer> ().material.color = Color.red;
				else {
					map [currentX] [currentY].GetComponent<Renderer> ().material.color = Color.blue;
					map [currentX] [currentY].InRange = true;
				}
				
			}
		}
		if (depth <= 0)
			return;
		colorIterate (depth, map, currentX, currentY - 1);
		colorIterate (depth, map, currentX + 1, currentY);
		colorIterate (depth, map, currentX, currentY + 1);
		colorIterate (depth, map, currentX - 1, currentY);
	}

	private bool isThereSomething(List<List<Tile>> map, int posX, int posY)
	{
		foreach (FightEventPlayer p in MapGenerator.instance.ennemies) {
			if (Mathf.Approximately (map[posX][posY].transform.position.x, p.transform.position.x) && Mathf.Approximately (map[posX][posY].transform.position.z, p.transform.position.z)) {
				return (true);
			}
		}
		return (false);
	}

	private void resetColor()
	{
		var map = MapGenerator.instance.map;
		foreach (List<Tile> tilesX in map) {
			foreach (Tile tile in tilesX) {
				tile.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}
}
