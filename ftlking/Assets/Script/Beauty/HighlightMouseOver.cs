using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightMouseOver : MonoBehaviour {

	private Color startcolor;

	void OnMouseEnter()
	{
		//this.guiText.text = "HelloWorld";
		startcolor = GetComponent<Renderer> ().material.color;
		GetComponent<Renderer>().material.color = Color.red;
		foreach (Renderer variableName in GetComponentsInChildren<Renderer>()) {
			variableName.material.color = Color.red;
		}

	}

	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor;
		foreach (Renderer variableName in GetComponentsInChildren<Renderer>()) {
			variableName.material.color = startcolor;
		}
	}
}
