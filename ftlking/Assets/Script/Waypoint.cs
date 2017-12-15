using System;
using Script;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Vector3 Position { get; set; }
    public EventManager Event { get; set; }
    public String Description { get; set; }
    public Boolean IsVisited { get; set; }

    void Start()
    {
    }

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space) && IsVisited == true)
			Debug.Log ("Doing event"); //Put your event here
	}
		
	void OnTriggerEnter()
	{
		IsVisited = true;
		Debug.Log ("Entering");
	}

	void OnTriggerExit()
	{
		IsVisited = false;
		Debug.Log ("Leaving");
	}
}