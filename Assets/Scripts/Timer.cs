using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float timeCounter = 0;
	private bool keyDown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown("l")) //key hold
		{
			keyDown = true;
		}

		else if(Input.GetKeyUp("l"))
		{
			keyDown = false;
		}

		if(keyDown)
		{
			timeCounter += Time.deltaTime;
			print(timeCounter);
		}
		else
		{
			timeCounter = 0;
		}
	}
}
  