using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine.Networking.NetworkSystem;

public class Character : MonoBehaviour
{
	public new String name;
	public int Health;
	public Dictionary<String, Item> Inventory;
	public GameObject characterEntity;
	public GameObject brick;
	
	// Use this for initialization
	Character()
	{
		characterEntity = brick;
	}
	void Start ()
	{
		Instantiate(characterEntity.transform, new Vector3(0, 0, 0), Quaternion.identity); //TODO Fix l'init d'un obj au run time
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
