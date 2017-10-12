using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAirlock : MonoBehaviour 
{
	public bool isActive = false;
	public GameObject[] wallsToClose;

	void OnTriggerEnter2D(Collider2D colliderHit)
	{

		if (colliderHit.CompareTag ("Player") && !isActive)
		{
			isActive = true;
			for (int i = 0; i < wallsToClose.Length; i++)
				wallsToClose [i].SetActive (true);
		}
	}
}
