using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonController : MonoBehaviour
{
    private ThirdPersonMovement thirdPersonMovement;
    private Vector2 movementInput;

    // Start is called before the first frame update
    void Start()
    {
        thirdPersonMovement = GetComponent<ThirdPersonMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        thirdPersonMovement.Move(movementInput);
    }

    public void OnAccelerate(InputValue value)
    {
        float inputValue= moveInput.x;
        actualDirection = cameraTransform.TransformDirection(controlDirection);

        movementInput = value.Get<Vector2>();
    }

    public void OnTurn()
    {

    }

    public void OnBrake()
    {

    }

    public void OnJump(InputValue value)
    {
        Debug.Log("jump: " + value);
    }

    public void OnDrift(InputValue value)
    {
        Debug.Log("drift: " + value);
    }

    public void OnBoost(InputValue value)
    {
        Debug.Log("boost: " + value);
    }
}
