using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enpoint : MonoBehaviour {

	public float speed;
	private bool pressed = false;
	private GameObject destinationObject;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.tag == "Waypoint") {
					pressed = true;
					Debug.Log (hit.collider.name);
				}
			}
		}
		if (pressed == true && hit.collider.tag == "Waypoint") {
			float swim = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, hit.collider.transform.position, swim);
			if (transform.position == hit.collider.transform.position) {
				pressed = false;
				//Application.LoadLevel ("Debug");
				// Load level here
			}
		}
	}
		
}
