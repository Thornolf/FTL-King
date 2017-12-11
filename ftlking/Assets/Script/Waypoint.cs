using System;
using Script;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public GameObject GameobjectRep { get; set; }
    public Vector3 Position { get; set; }
    public Situation Event { get; set; }
    public String Description { get; set; }
    public Boolean IsVisited { get; set; }

    private void OnMouseOver()
    {
        Debug.Log("The mouse is over the object");
    }

    private void OnMouseDown()
    {
        Debug.Log("The mouse click on it");
    }
}