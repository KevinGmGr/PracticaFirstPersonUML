using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : Entity_Script {

	public float Damage = 10f;

	// Use this for initialization
	void Start () {
		HP = 30f;
	}

	// Update is called once per frame
	void Update () {
		
	}

	public override void ApplyDamage(){
		HP -= Damage;
		Debug.Log (HP);
	}

	public void OnCollisionEnter (Collision Col){
		if(Col.gameObject.tag == "Bullet"){
			ApplyDamage ();
		}
	}

}
