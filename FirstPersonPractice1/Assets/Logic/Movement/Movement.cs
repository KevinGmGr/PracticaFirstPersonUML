using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour {

    protected Vector3 Direction = new Vector3();
    protected float Speed;
    protected float JumpForce;
    protected float gravity = -9.8f;
	// Use this for initialization
	void Start () {
		



	}
	
	// Update is called once per frame
	void Update () {
		
	}
    virtual public void Move()
    {

    }
}
