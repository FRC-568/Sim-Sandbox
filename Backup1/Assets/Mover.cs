using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public WheelCollider wheelBL;
    public WheelCollider wheelBR;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public GameObject centerOfMass;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {

            wheelFR.motorTorque = 500;
            wheelFL.motorTorque = -500;
            wheelBL.motorTorque = -500;
            wheelBR.motorTorque = 500;
            wheelFL.steerAngle = 0;
        }
            if (Input.GetAxis("Horizontal") > 0)
        {
            wheelFR.motorTorque = -500;
            wheelFL.motorTorque = 500;
            wheelBL.motorTorque = 500;
            wheelBR.motorTorque = -500;
            wheelFL.steerAngle = 0;
        }
            if (Input.GetAxis("Vertical") < 0)
        {
            wheelBL.motorTorque = -500;
            wheelBR.motorTorque = -500;
            wheelFL.steerAngle = 0;
        }
            if (Input.GetAxis("Vertical") > 0)
        {
            wheelBL.motorTorque = 500;
            wheelBR.motorTorque = 500;
            wheelFL.steerAngle = 0;
        }
      

        }
    }
