using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Script : Enemy_Script {


    enum TurretStates { Idle, Detected, Shooting };
    TurretStates currentstate;
    public GameObject PlayerRef;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


        switch (currentstate)
        {
            case TurretStates.Idle:

                break;

            case TurretStates.Detected:

                if(!Physics.Raycast(this.transform.position,  ( PlayerRef.transform.position - this.transform.position).normalized, (PlayerRef.transform.position - this.transform.position).magnitude))
                {
                    ChangeState(TurretStates.Shooting);

                }
                break;

            case TurretStates.Shooting:

                break;

        }

        Debug.Log(currentstate);

    }

    private void ChangeState(TurretStates NewState) {

        switch (currentstate)
        {

        }

        switch (NewState)
        {

        }

        currentstate = NewState;

    }

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag =="Player")
        {
           PlayerRef = Col.gameObject;
            ChangeState(TurretStates.Detected);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerRef = null;
            ChangeState(TurretStates.Idle);
        }
    }
}
