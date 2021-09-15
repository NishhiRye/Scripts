using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    
    public float baseSpeed = 7f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float sprint = 12f;
    public float walking = 7f;
    public float slowWalking = 3f;
    
    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

  
    void Update()
    {        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); 

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * baseSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);            
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            baseSpeed = sprint;
        }
        
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            baseSpeed = walking;                 
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            baseSpeed = slowWalking;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            baseSpeed = walking;
        }

                
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
