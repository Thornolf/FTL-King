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

    private void OnMouseDown()
    {
    }
}