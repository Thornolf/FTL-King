using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

	public static MapGenerator instance;

	public GameObject TilePrefab;
	public GameObject CharactPrefab;

	public int SizeMap = 20;

	List<List<Tile>> map = new List<List<Tile>>();
	public List<FightEventPlayer> players = new List<FightEventPlayer>();

	void Awake() {
		instance = this;
	}

	// Use this for initialization
	void Start () {
		generateMap ();
		generatePlayers ();
		generateEnemies ();
	}
	
	// Update is called once per frame
	void Update () {
		players [0].moveUpdate ();
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
		}
	}

	void generatePlayers()
	{
		FightEventPlayer charac;

		charac = ((GameObject)Instantiate(CharactPrefab, new Vector3(Mathf.Floor(SizeMap / 2), 0.6f, Mathf.Floor(SizeMap / 2)), Quaternion.Euler(new Vector3()))).GetComponent<FightEventPlayer>();
		players.Add (charac);
	}

	void generateEnemies() {
		FightEventPlayer charac;

		charac = ((GameObject)Instantiate(CharactPrefab, new Vector3(4 - Mathf.Floor(SizeMap / 2), 0.6f, -4 + Mathf.Floor(SizeMap / 2)), Quaternion.Euler(new Vector3()))).GetComponent<FightEventPlayer>();
		players.Add (charac);
	}

	public void moveCurrentPlayer(Tile destTile) {
		players[0].moveDestination = destTile.transform.position + 1.5f * Vector3.up;
	}
}
