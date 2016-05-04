using UnityEngine;
using System.Collections;

public class ActivateCheck : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			PlayerMovement.activeCheckpoint = transform;
		}
	}
}
