using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTransfer : MonoBehaviour 
{
	public bool enablesTopFloor;
	public FloorControl controller;

	void OnTriggerEnter2D(Collider2D colliderHit)
	{

		if (colliderHit.CompareTag ("Player"))
		{
			if (controller.upperFloorActive && !enablesTopFloor)
				controller.GoToLower ();
			else if (!controller.upperFloorActive && enablesTopFloor)
				controller.GoToUpper ();
		}
	}
}
