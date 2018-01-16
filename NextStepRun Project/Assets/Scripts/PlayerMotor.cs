using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float jumppwr = 12.0f;
    private float VerticalVelocity = 0.0f;
    private float Gravity = 30.0f;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    public void Move()
    {
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            //VerticalVelocity = -0.1f;
            VerticalVelocity = Input.GetAxisRaw("Jump") * jumppwr;
        }
        else
        {
            VerticalVelocity -= Gravity * Time.deltaTime;
        }

        //y fel-le        
        moveVector.y = VerticalVelocity;
        //x bal-jobb
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //z előre-hátra
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);
    }


}
