using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Script;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class BoatMove: MonoBehaviour {

	public Camera cam;
	public float speed;
	public List<Waypoint> ListWaypoint = new List<Waypoint>();
	private bool pressed = false;
	private GameObject destinationObject;
	private RaycastHit hit;
	private GameManager gameManager = GameManager.Instance;

	// Use this for initialization
	void Start ()
	{
		int newId = 1;
		foreach (var vWayypoint in ListWaypoint)
		{
			vWayypoint.Id = newId++;
		}
		
		Vector3 v = new Vector3(gameManager.ActualPlayer.PlayerhShip.Position.x, gameManager.ActualPlayer.PlayerhShip.Position.y, gameManager.ActualPlayer.PlayerhShip.Position.z);
		this.transform.position = v; //TODO Vérifié que la pos de l'instance est bien la réel position du ship
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
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			foreach (var vWaypoint in ListWaypoint)
			{
				Debug.Log("Id : " + vWaypoint.Id);
			}
			
			SaveGame s = new SaveGame();
			s.Saving<Character>(gameManager.ActualPlayer.MainCharacter, "MainCharacter");
			s.Saving<Ship>(gameManager.ActualPlayer.PlayerhShip, "PlayerShip");
			s.Saving<List<Character>>(gameManager.ActualPlayer.Company, "Company");
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Waypoint")
		{
			pressed = false;
			// CAM
			Vector3 velocity = Vector3.zero;
			Vector3 newPos = new Vector3 (transform.position.x, cam.transform.position.y, transform.position.z);
			cam.transform.position = Vector3.SmoothDamp (newPos, transform.position, ref velocity, 0.3f);
			Debug.Log("I'm in the collider tag == Waypoin and my position is : " + collider.gameObject.transform.position);
		}
		gameManager.ActualPlayer.PlayerhShip.Position.setAllAxe(collider.transform.position.x, collider.transform.position.y, collider.transform.position.z);
	}
	
}
