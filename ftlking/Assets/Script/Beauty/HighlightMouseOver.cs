using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightMouseOver : MonoBehaviour {

	private Color startcolor;

	void OnMouseEnter()
	{
		startcolor = GetComponent<Renderer> ().material.color;
		GetComponent<Renderer>().material.color = Color.red;
	}

	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor;
	}
}
