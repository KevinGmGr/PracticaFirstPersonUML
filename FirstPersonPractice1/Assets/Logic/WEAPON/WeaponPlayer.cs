using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPlayer : Weapon {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Shot()
    {
        Instantiate(bulletref, this.transform.position, this.transform.rotation);
        base.Shot();
    }
    public override void Reaload(float CurrentAmmo)
    {

        MaxMunition = this.GetComponent<Entity_Script>().MaxAmmo;
        CurrentAmmo = MaxMunition;
        base.Reaload(CurrentAmmo);
        this.GetComponent<Entity_Script>().SetAmmo(CurrentAmmo);
    }
}
