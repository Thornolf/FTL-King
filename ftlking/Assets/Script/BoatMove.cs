using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class BoatMove: MonoBehaviour {

	public float speed;
	private bool pressed = false;
	private GameObject destinationObject;
	private RaycastHit hit;
	private GameManager gameManager = GameManager.Instance;

	// Use this for initialization
	void Start ()
	{
		this.transform.position = gameManager.ActualPlayer.PlayerhShip.Position; //TODO Vérifié que la pos de l'instance est bien la réel position du ship
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0) && pressed == false)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.tag == "Waypoint") {
					pressed = true;
					GetComponent<NavMeshAgent>().SetDestination(hit.point);
				}
			}
		}
		if (pressed == true && hit.collider.tag == "Waypoint") {

			if (transform.position == hit.collider.transform.position) {
				pressed = false;
				//Application.LoadLevel ("Debug");
			}
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Waypoint")
		{
			pressed = false;
		}
		gameManager.ActualPlayer.PlayerhShip.Position = collider.transform.position;
	}
}
