using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrigger : MonoBehaviour {

	public MapGenerator mapInstance = MapGenerator.instance;

	void Start () {
		mapInstance = MapGenerator.instance;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void EndTurn() {
		foreach (FightEventPlayer p in mapInstance.players)
			p.resetTurn ();
		Turn.turnID++;
	}
}
