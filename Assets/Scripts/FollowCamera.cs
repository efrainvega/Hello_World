using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour 
{

	[SerializeField]
	private Transform player;

	[SerializeField]
	private Vector3 offset;

    [SerializeField]
    private float cameraFollowSpeed = 5.0f;

	
	// Update is called once per frame
	void Update () 
	{
		//Vector3 newPosition = player.position + offset;
        Vector3 altPos = new Vector3(player.position.x, 0.0f, player.position.z) + offset;

		//transform.position = Vector3.Lerp(transform.position, newPosition, cameraFollowSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, altPos, cameraFollowSpeed * Time.deltaTime);

    }
}
