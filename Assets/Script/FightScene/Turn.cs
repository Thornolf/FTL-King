using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

	public static int turnID = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (turnID == 3)
			turnID = 1;
		Debug.Log ("Turn : " + turnID);
	}
}
