using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement {


    CharacterController charRefernce;
	// Use this for initializationpuli
	void Start () {
        charRefernce = this.GetComponent<CharacterController>();
        Speed = 10f;

    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    public override void Move()
    {
        if (Input.GetAxis ("Jump") != 0 &&charRefernce.isGrounded == true)
        {
            CurrentJumpForce = JumpForce;          
        }
        else if (charRefernce.isGrounded == true)
        {
            CurrentJumpForce = 0;
        }
        else
        {
            CurrentJumpForce += (gravity * Time.deltaTime);
        }
       

        Direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Direction = transform.TransformDirection(Direction);        
        Direction *= Speed;
        Direction += Vector3.up * CurrentJumpForce;
        charRefernce.Move(Direction * Time.deltaTime);
    


        base.Move();
    }


}
