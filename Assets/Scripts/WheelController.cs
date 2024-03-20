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

    float currentAcceleration = 0f;
    float currentTurnAngle = 0;


    public void OnMove(InputAction.CallbackContext context)
    {
        currentAcceleration = acceleration * context.ReadValue<Vector2>().y;

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        currentTurnAngle = maxTurnAngle * context.ReadValue<Vector2>().x;
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
    }
}
