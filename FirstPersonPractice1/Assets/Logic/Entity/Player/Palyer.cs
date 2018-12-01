using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyer : Entity_Script {

	// Use this for initialization
	void Start () {
        MaxAmmo = 40;
       Ammo= 40;
        Debug.Log(Ammo);
	}
	
	// Update is called once per frame
	void Update () {

        CurrentTime = Time.deltaTime;

        if (Input.GetAxis("Fire1")!=0  && Ammo >0 )
        {
            this.GetComponent<Weapon>().Shot();
            reloadTime = 0;
            Ammo--;
            Debug.Log(Ammo);
        }
        Reload();

	}
    public override void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R) == true && Ammo <= 0)
        {
            this.GetComponent<Weapon>().Reaload(Ammo);
        }

        base.Reload();
    }
    public override void SetAmmo(float newAmmo)
    {
        newAmmo = Ammo;


        base.SetAmmo(Ammo);
    }

}
