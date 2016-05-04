using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	KeyValuePair<string, int> studentInfo;

	// Use this for initialization
	void Start ()
	{
		studentInfo = new KeyValuePair<string, int>("Nic H", 19);

		print(studentInfo.Key);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
