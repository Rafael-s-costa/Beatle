using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    private float speed = 0f;
    public float acceleration;

    private Vector2 moveAmmount;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        acceleration = 1f;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputDirection = new Vector3(moveAmmount.x, 0, moveAmmount.y);
        var actualDirection = cameraTransform.TransformDirection(controlDirection);
        characterController.Move(moveAmmount);
    }

    public void Move(Vector2 moveInput)
    {
        inputDirection = new Vector3(moveInput.x, 0, moveInput.y);
        actualDirection = cameraTransform.TransformDirection(controlDirection);
    }
}
