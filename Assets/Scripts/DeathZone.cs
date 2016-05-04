using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

    [SerializeField]
    private GameObject player;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = player.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = startPosition;
    }
}
