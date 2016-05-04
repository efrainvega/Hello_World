using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 6.0f;

    [SerializeField]
    private float jumpMax = 10.0f;

	static public Transform activeCheckpoint;

    //private CharacterController controller;
    //public float speed = 6.0F;
    //public float jumpSpeed = 10.0F;
    //public float gravity = 20.0F;
    //private Vector3 moveDirection = Vector3.zero;

    private float distToGround;

    void Start()
    {
        //controller = GetComponent<CharacterController>();
        distToGround = GetComponent<Collider>().bounds.extents.y;
        
    }

    void Update()
    {
        //print(distToGround);

		if(Input.GetKeyDown("t"))
		{
			TeleportToCheckpoint();
		}

        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        float moveVertical = 0;
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        Vector3 movement;

        //print(GetComponent<Rigidbody>().velocity.y);

        //if (Input.GetKeyDown("space") && (GetComponent<Rigidbody>().velocity.y < 0.05f && GetComponent<Rigidbody>().velocity.y > -0.05f))
        if (Input.GetKeyDown("space") && IsGrounded())
        {
            moveVertical += jumpMax ;
            movement = new Vector3(0.0f, moveVertical, 0.0f);
        }
        else
        {
            movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        }

        GetComponent<Rigidbody>().AddForce(movement * speed);

        //GetComponent<Rigidbody>().velocity = movement * speed;
    }


    //void Update()
    //{
        //if (controller.isGrounded)
        //{
        //    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        //    moveDirection = transform.TransformDirection(moveDirection);
        //    moveDirection *= speed;

        //    if (Input.GetButton("Jump"))
        //    {
        //        moveDirection.y = jumpSpeed;
        //    }
        //}
        //moveDirection.y -= gravity * Time.deltaTime;
        //controller.Move(moveDirection * Time.deltaTime);
    //}

    bool IsGrounded()
    {
        bool grounded = Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
        return grounded;
    }

	void TeleportToCheckpoint()
	{
		transform.position = activeCheckpoint.position;
	}
}