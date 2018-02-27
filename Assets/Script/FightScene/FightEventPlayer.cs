using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightEventPlayer : MonoBehaviour {

	public Vector3 moveDestination;
	public float movespeed = 10.0f;
	public int movementpointLeft = 4;
	public int attackRange = 1;
	public bool movementDone = false;
	public bool attackDone = false;
	public MapGenerator mapInstance;


	void Awake() {
		moveDestination = transform.position;
	}

	// Use this for initialization
	void Start () {
		mapInstance = MapGenerator.instance;
	}
	
	// Update is called once per frame
	void Update () {
		moveDestination.y = 0.5f;
	}
		
	public void moveUpdate(Tile tileDes) {
		moveDestination.x = tileDes.transform.position.x;
		moveDestination.z = tileDes.transform.position.z;
		if (Vector3.Distance (moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * movespeed * Time.deltaTime;

			if (Vector3.Distance (moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
				changeColorOnDeselect ();
				mapInstance.selectedPlayer = null;
				mapInstance.resetColor ();
				mapInstance.selectedTile = null;
				movementDone = true;
			}
		}
	}

	public void attackTarget(Tile tileTar)
	{
		mapInstance.selectedPlayer = null;
		mapInstance.resetColor ();
		mapInstance.selectedTile = null;
		attackDone = true;
		changeColorOnDeselect ();
		Debug.Log ("Blood and plunder");
	}

	public void colorMovementTile()
	{
		var depth = movementpointLeft;
		var map = mapInstance.map;
		var pSelected = mapInstance.selectedPlayer;
		int indexTileX = 0;
		int indexTileY = 0;	
		Tile rightTile;

		foreach (List<Tile> tilesX in map) {
			foreach (Tile tile in tilesX) {
				
				if (Mathf.Approximately (pSelected.transform.position.x, tile.transform.position.x) && Mathf.Approximately (pSelected.transform.position.z, tile.transform.position.z)) {
					
					rightTile = map[indexTileX][indexTileY];
					colorIterate (depth, map, indexTileX, indexTileY - 1, Color.blue);
					colorIterate (depth, map, indexTileX + 1, indexTileY, Color.blue);
					colorIterate (depth, map, indexTileX, indexTileY + 1, Color.blue);
					colorIterate (depth, map, indexTileX - 1, indexTileY, Color.blue);
				}
				indexTileY++;
			}
			indexTileY = 0;
			indexTileX++;
		}
	}

	public void colorAttackTile()
	{
		var depth = attackRange;
		var map = mapInstance.map;
		var pSelected = mapInstance.selectedPlayer;
		int indexTileX = 0;
		int indexTileY = 0;	
		Tile rightTile;

		foreach (List<Tile> tilesX in map) {
			foreach (Tile tile in tilesX) {

				if (Mathf.Approximately (pSelected.transform.position.x, tile.transform.position.x) && Mathf.Approximately (pSelected.transform.position.z, tile.transform.position.z)) {

					rightTile = map[indexTileX][indexTileY];
					colorIterate (depth, map, indexTileX, indexTileY - 1, Color.yellow);
					colorIterate (depth, map, indexTileX + 1, indexTileY, Color.yellow);
					colorIterate (depth, map, indexTileX, indexTileY + 1, Color.yellow);
					colorIterate (depth, map, indexTileX - 1, indexTileY, Color.yellow);
				}
				indexTileY++;
			}
			indexTileY = 0;
			indexTileX++;
		}
	}

	private void colorIterate(int depth, List<List<Tile>> map, int currentX, int currentY, Color color)
	{
		
		depth--;
		if (currentX >= 0 && currentY >= 0) {
			if (currentX < map.Count && currentY < map.Count) {
				if (isThereSomething (map, currentX, currentY) == true)
					map [currentX] [currentY].GetComponent<Renderer> ().material.color = Color.red;
				else {
					map [currentX] [currentY].GetComponent<Renderer> ().material.color = color;
					map [currentX] [currentY].InRange = true;
				}
				
			}
		}
		if (depth <= 0)
			return;
		colorIterate (depth, map, currentX, currentY - 1, color);
		colorIterate (depth, map, currentX + 1, currentY, color);
		colorIterate (depth, map, currentX, currentY + 1, color);
		colorIterate (depth, map, currentX - 1, currentY, color);
	}

	private bool isThereSomething(List<List<Tile>> map, int posX, int posY)
	{
		foreach (FightEventPlayer p in mapInstance.ennemies) {
			if (Mathf.Approximately (map[posX][posY].transform.position.x, p.transform.position.x) && Mathf.Approximately (map[posX][posY].transform.position.z, p.transform.position.z)) {
				return (true);
			}
		}
		return (false);
	}

	private void resetColor()
	{
		var map = mapInstance.map;
		foreach (List<Tile> tilesX in map) {
			foreach (Tile tile in tilesX) {
				tile.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}
		
	public void resetTurn()
	{
		attackDone = false;
		movementDone = false;
	}

	public void changeColorOnSelect()
	{

		this.GetComponent<Renderer>().material.color = Color.red;
		foreach (Renderer variableName in this.GetComponentsInChildren<Renderer>()) {
			variableName.material.color = Color.magenta;
		}
	}

	public void changeColorOnDeselect()
	{
		foreach (Renderer variableName in this.GetComponentsInChildren<Renderer>()) {
			variableName.material.color = Color.white;
		}
	}
}
