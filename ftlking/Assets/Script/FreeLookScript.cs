using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLookScript : MonoBehaviour {

	public float panSpeed = 20.0f;
	public float panBorderThickness = 10.0f;
	public Vector2 panLimit;

	public Vector2 yLimit;

	public float scrollSpeed = 20.0f;

	void Update () {

		float scroll = Input.GetAxis ("Mouse ScrollWheel");
		Vector3 pos = transform.position;

		if (Input.GetKey ("z") || Input.mousePosition.y >= Screen.height - panBorderThickness) 
		{
			pos.z += panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("s") || Input.mousePosition.y <= panBorderThickness) 
		{
			pos.z -= panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("d") || Input.mousePosition.x >= Screen.width - panBorderThickness) 
		{
			pos.x += panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("q") || Input.mousePosition.x <= panBorderThickness) 
		{
			pos.x -= panSpeed * Time.deltaTime;
		}

		pos.y -= scroll * scrollSpeed * 100.0f * Time.deltaTime;

		pos.x = Mathf.Clamp (pos.x, -panLimit.x, panLimit.x);
		pos.z = Mathf.Clamp (pos.z, -panLimit.y, panLimit.y);
		pos.y = Mathf.Clamp (pos.y, yLimit.x, yLimit.y);

		transform.position = pos;
	}
}
