using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControl : MonoBehaviour 
{
	public bool upperFloorActive;
	public GameObject upperFloor;
	public GameObject lowerFloor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoToUpper()
	{
		upperFloorActive = true;
		upperFloor.SetActive (true);
		lowerFloor.SetActive (false);
	}

	public void GoToLower()
	{
		upperFloorActive = false;
		upperFloor.SetActive (false);
		lowerFloor.SetActive (true);
	}
}
