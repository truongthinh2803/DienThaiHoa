using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVeclocity;
    private bool isGrounded; 
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }

    public void ProcessMove(Vector3 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y; 
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        if ( isGrounded && playerVeclocity.y < 0)
            playerVeclocity.y = -2f;
        playerVeclocity.y += gravity + Time.deltaTime; 
        controller.Move(playerVeclocity * Time.deltaTime);
        Debug.Log(playerVeclocity.y);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVeclocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
