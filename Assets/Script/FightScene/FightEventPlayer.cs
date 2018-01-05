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
	}

	public void moveUpdate() {
		if (Vector3.Distance (moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * movespeed * Time.deltaTime;

			if (Vector3.Distance (moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
			}
		}
	}
}
