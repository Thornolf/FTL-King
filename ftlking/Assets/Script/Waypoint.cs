using System;
using Script;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class Waypoint : MonoBehaviour
{
    public Vector3 Position { get; set; }
    public EventManager Event { get; set; }
    public String Description { get; set; }
    public Boolean IsVisited { get; set; }
	public Boolean IsEventDone { get; set; }
	private Color startcolor;
	public float Cooldown;
	private GameManager _gameManager = GameManager.Instance;


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
			SelectEvent();
		}
		if (IsEventDone == true) {
			Cooldown -= Time.deltaTime;
			if (Cooldown < 0) {
				IsEventDone = false;
				GetComponent<Renderer> ().material.color = startcolor;
			}
		}
	}

	private void SelectEvent()
	{
		//Debug.Log("Event : " + _gameManager.ListEvent[UnityEngine.Random.Range(0, _gameManager.ListEvent.Count)].ToString());
		
		Array values = Enum.GetValues(typeof(eEventType));
		Random random = new Random();
		eEventType randomEvent = (eEventType)values.GetValue(random.Next(values.Length));

		switch (randomEvent)
		{
			case eEventType.Fight:
				SceneManager.LoadScene("EventFighting");
				break;
			case eEventType.Fishing:
				SceneManager.LoadScene("EventFishing");
				break;
			case eEventType.Trade:
				SceneManager.LoadScene("EventTrading");
				break;
			case eEventType.Hunting:
				Debug.Log("I am doing HUNTING");
				break;
			case eEventType.Nothing:
				Debug.Log("I am doing NOTHING");
				break;
			default:
				Debug.Log("It is impossible to have this output.");
				break;
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