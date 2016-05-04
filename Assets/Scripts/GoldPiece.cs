using UnityEngine;
using System.Collections;

public class GoldPiece : MonoBehaviour {

	public bool goldActive = true;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			goldActive = false;

			gameObject.SetActive(false);
		}
	}
}
