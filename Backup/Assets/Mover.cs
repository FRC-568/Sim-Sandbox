using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public WheelCollider wheelBL;
    public WheelCollider wheelBR;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        if (Input.GetAxis("Vertical") > 0)
        {
            wheelBL.motorTorque = 5;
            wheelFL.steerAngle = 0;
        }
    }
}
