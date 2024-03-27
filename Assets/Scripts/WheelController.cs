using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WheelController : MonoBehaviour
{

    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;
    [SerializeField] float maxTurnAngle = 15f;

    [SerializeField] float acceleration = 500f;

    [SerializeField] Transform frontRightWheelMesh;
    [SerializeField] Transform frontLeftWheelMesh;
    [SerializeField] Transform backRightWheelMesh;
    [SerializeField] Transform backLeftWheelMesh;

    float currentAcceleration = 0f;
    float currentTurnAngle = 0;


    public void OnMove(InputAction.CallbackContext context)
    {
        currentAcceleration = acceleration * context.ReadValue<Vector2>().y;

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        // backRight.motorTorque = currentAcceleration;
        // backLeft.motorTorque = currentAcceleration;

        currentTurnAngle = maxTurnAngle * context.ReadValue<Vector2>().x;
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
    }

    private void FixedUpdate()
    {
        SetWheel(frontRight, frontRightWheelMesh);
        SetWheel(frontLeft, frontLeftWheelMesh);
        SetWheel(backRight, backRightWheelMesh);
        SetWheel(backLeft, backLeftWheelMesh); 
    }

    void SetWheel(WheelCollider wheelCol, Transform wheelMesh)
    {
        Debug.Log(wheelCol);
        Debug.Log(wheelMesh);
        
        Vector3 pos;
        Quaternion rot;
        wheelCol.GetWorldPose(out pos, out rot);

        wheelMesh.position = pos;
        wheelMesh.rotation = rot;
    }
}
