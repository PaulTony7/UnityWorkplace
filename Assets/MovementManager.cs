using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public float Speed =10;
    public float JumpSpeed =1;
    public Rigidbody rigidbody;

   
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Jump();
        Vector3 playerMovement = new Vector3(horizontal, 0, vertical).normalized * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

    void Jump(){
        if(Input.GetAxis("Jump")>0) { 
            rigidbody.AddForce(Vector3.up *JumpSpeed);
        }
    }
}
