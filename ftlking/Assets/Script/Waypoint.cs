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
		if (transform.position == GameObject.FindGameObjectWithTag ("Player").transform.position && IsVisited == false) {
			IsVisited = true;
			//Application.LoadLevel("DevEventSceneVillage"); LOAD YOUR SCENE HERE
			Debug.Log ("Passing on isle");
		}
			
	}

    private void OnMouseDown()
    {
		if (IsVisited == true)
			Debug.Log ("info");
    }
}