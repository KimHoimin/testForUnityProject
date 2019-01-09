using UnityEngine;
using System.Collections;

public class csCCMove : MonoBehaviour
{
    float gravity = -20.0f;
    float jumpSpeed = 10.0f;
    CharacterController con;
    public float movSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    Vector3 moveDirection;
    // Use this for initialization
    void Start()
    {
        con = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (con.isGrounded)
        {
            float amtMove = movSpeed * Time.deltaTime;
            float amtRot = rotSpeed * Time.deltaTime;

            float ver = Input.GetAxis("Vertical");
            float ang = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * amtRot * ang);

            moveDirection = transform.TransformDirection(Vector3.forward * ver * movSpeed);
            
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y += (gravity * Time.deltaTime);
        con.Move(moveDirection * Time.deltaTime);
        
    }
}
