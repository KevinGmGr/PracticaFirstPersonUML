using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity_Script : MonoBehaviour {

	protected float HP;
	protected float MaxHealth;
	protected float Ammo;
	protected float MaxAmmo;
	protected float AmmoReload;
	protected float MovAx;
	protected float JumpAx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	virtual public void ApplyDamage(){

	}

	virtual public void Death(){

	}

	virtual public void AddHealth(){

	}

	virtual public void Reload(){

	}
}
