using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement {


    CharacterController charRefernce;
	// Use this for initializationpuli
	void Start () {
        charRefernce = this.GetComponent<CharacterController>();
        Speed = 10f;
        JumpForce = 500f;

    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    public override void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&charRefernce.isGrounded == true)
        {
            Direction.y = JumpForce;
            Direction.y = Direction.y - (gravity * Time.deltaTime);
        }
        else
        {
            Direction.y = Direction.y - (gravity * Time.deltaTime);
        }
        if (charRefernce.isGrounded == true)
        {
            Direction.y = 0;
        }

        Direction = new Vector3(Input.GetAxis("Horizontal"), Direction.y, Input.GetAxis("Vertical"));
        Direction = transform.TransformDirection(Direction);
        Direction *= Speed;
        charRefernce.Move(Direction * Time.deltaTime);
    


        base.Move();
    }


}
