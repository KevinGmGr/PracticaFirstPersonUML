using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Script : Enemy_Script {

    enum TurretStates {Idle, Detected, Shooting};
    TurretStates currentstate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        switch (currentstate)
        {
            case Idle:

            break;

            case Detected:

            break;

            case Shooting:

            break;

        }

	}
}
