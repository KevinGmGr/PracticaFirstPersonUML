using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Weapon : MonoBehaviour {
    public GameObject bulletref;
    protected float MaxMunition;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
	
        


	}

    virtual public void Shot()
    {


    }
    virtual public void Reaload(float CurrentAmmo)
    {



    }
}
