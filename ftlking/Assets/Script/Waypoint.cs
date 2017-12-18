using System;
using Script;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Vector3 Position { get; set; }
    public EventManager Event { get; set; }
    public String Description { get; set; }
    public Boolean IsVisited { get; set; }
	public Boolean IsEventDone { get; set; }
	private Color startcolor;
	public float Cooldown;


    void Start()
    {
		IsEventDone = false;
    }

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space) && IsVisited == true && IsEventDone == false)
		{
			startcolor = GetComponent<Renderer> ().material.color;
			GetComponent<Renderer>().material.color = Color.green;
			IsEventDone = true;
			Cooldown = 5f;
			Debug.Log ("Doing event"); //Put your event here
		}
		if (IsEventDone == true) {
			Cooldown -= Time.deltaTime;
			if (Cooldown < 0) {
				IsEventDone = false;
				GetComponent<Renderer> ().material.color = startcolor;
			}
		}
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