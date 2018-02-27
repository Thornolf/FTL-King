using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

	public static MapGenerator instance;

	public GameObject TilePrefab;
	public GameObject CharactPrefab;
	public GameObject EnnemiPrefab;


	public int SizeMap = 20;

	public List<List<Tile>> map = new List<List<Tile>>();
	public List<FightEventPlayer> players = new List<FightEventPlayer>();
	public List<FightEventPlayer> ennemies = new List<FightEventPlayer>();
	public FightEventPlayer selectedPlayer = new FightEventPlayer();

	public bool selected = false;
	public Tile selectedTile = new Tile();

	private enum Action
	{
		Idle = 0,
		Attack,
		Movement
	};

	Action curAction = Action.Idle;

	void Awake() {
		instance = this;
	}
		
	// Use this for initialization
	void Start () {
		generateMap ();
		generatePlayers ();
		generateEnemies ();
		selectedPlayer = null;
	}
	
	// Update is called once per frame
	void Update () {
		if (selectedPlayer != null && selected == false) {
			selected = true;
		} else if (selectedPlayer == null && selected == true) {
			resetColor();
			selected = false;
			curAction = Action.Idle;
		}
		if (curAction == Action.Movement && selectedPlayer != null && selectedPlayer.movementDone == false)
			selectedPlayer.colorMovementTile ();
		if (curAction == Action.Attack && selectedPlayer != null && selectedPlayer.attackDone == false)
			selectedPlayer.colorAttackTile ();
		if (selectedPlayer != null && selectedTile != null && selectedTile.InRange == true && curAction == Action.Movement)
			selectedPlayer.moveUpdate (selectedTile);
		if (selectedPlayer != null && selectedTile != null && selectedTile.InRange == true && curAction == Action.Attack)			
			selectedPlayer.attackTarget (selectedTile);
	}
		
	void generateMap()
	{
		map = new List<List<Tile>>();

		for (int i = 0; i <= SizeMap; i++) {
			List<Tile> row = new List<Tile> ();
			for (int j = 0; j <= SizeMap; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(i - Mathf.Floor(SizeMap / 2), 0, -j + Mathf.Floor(SizeMap / 2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				row.Add(tile);
			}
			map.Add (row);
		}
	}

	void generatePlayers()
	{
		FightEventPlayer charac;

		charac = ((GameObject)Instantiate(CharactPrefab, new Vector3(Mathf.Floor(SizeMap / 4), 0.6f, Mathf.Floor(SizeMap / 4)), Quaternion.Euler(new Vector3()))).GetComponent<FightEventPlayer>();
		players.Add (charac);
	}

	void generateEnemies() {
		FightEventPlayer charac;

		charac = ((GameObject)Instantiate(EnnemiPrefab, new Vector3(4 - Mathf.Floor(SizeMap / 2), 0.6f, -4 + Mathf.Floor(SizeMap / 2)), Quaternion.Euler(new Vector3()))).GetComponent<FightEventPlayer>();
		ennemies.Add (charac);
	}

	public void moveCurrentPlayer(Tile destTile) {
		selectedTile = destTile;
		//selectedPlayer.moveDestination = destTile.transform.position + 1.5f * Vector3.up;
	}
		
	public void resetColor()
	{
		var map = MapGenerator.instance.map;
		foreach (List<Tile> tilesX in map) {
			foreach (Tile tile in tilesX) {
				tile.GetComponent<Renderer> ().material.color = Color.white;
				tile.InRange = false;
			}
		}
	}

	public void IsAttacking()
	{
		if (selected) {
			curAction = Action.Attack;
			resetColor ();
		}
	}

	public void IsMoving()
	{
		if (selected) {
			curAction = Action.Movement;
			resetColor ();
		}
	}
}
