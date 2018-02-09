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
    public float coastTorque = 0;
    public float motorTorque = 500;
        
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
            wheelFL.steerAngle = -50;
            wheelFR.steerAngle = -50;
        }
            if (Input.GetAxis("Horizontal") > 0)
        {
            wheelFL.steerAngle = 50;
            wheelFR.steerAngle = 50;
        }
            if (Input.GetAxis("Horizontal") == 0)
        {
            wheelFL.steerAngle = 0;
            wheelFR.steerAngle = 0;
        }
            
            if (Input.GetAxis("Vertical") < 0)
        {
            wheelFR.motorTorque = -motorTorque;
            wheelFL.motorTorque = -motorTorque;
            wheelBL.motorTorque = -motorTorque;
            wheelBR.motorTorque = -motorTorque;
            wheelBL.brakeTorque = 0;
            wheelBR.brakeTorque = 0;
        }
            if (Input.GetAxis("Vertical") > 0)
        {
            wheelFR.motorTorque = motorTorque;
            wheelFL.motorTorque = motorTorque;
            wheelBL.motorTorque = motorTorque;
            wheelBR.motorTorque = motorTorque;
            wheelBL.brakeTorque = 0;
            wheelBR.brakeTorque = 0;
        }
            if (Input.GetAxis("Vertical") == 0)
        {
                wheelBL.brakeTorque = coastTorque;
                wheelBR.brakeTorque = coastTorque;
                wheelBL.motorTorque = 0;
                wheelBR.motorTorque = 0;
        }
      

        }
    }
