using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement {


    CharacterController charRefernce;
    // Use this for initializationpuli
    [SerializeField] Vector3 Rotate = new Vector3();
    [SerializeField] float RotateSpeed = 10;
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


        Rotate = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        Rotate *= RotateSpeed;

        /*  if (Rotate.y > 90)
          {
              Rotate.y = 90;

          }
          if(Rotate.y>-90){
              Rotate.y = -90;
          }*/
        Rotate = Rotate + this.transform.GetChild(0).rotation.eulerAngles;

         if (Rotate.y > 90)
          {
              Rotate.y = 90;

          }
          if(Rotate.y>-90){
              Rotate.y = -90;
          }

        this.transform.GetChild(0).rotation = Quaternion.Euler(Rotate);

        
        Direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Direction = transform.TransformDirection(Direction);        
        Direction *= Speed;
        Direction += Vector3.up * CurrentJumpForce;
        charRefernce.Move(Direction * Time.deltaTime);
    


        base.Move();
    }


}
