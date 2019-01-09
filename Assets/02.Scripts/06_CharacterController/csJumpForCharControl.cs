using UnityEngine;
using System.Collections;

public class csJumpForCharControl : MonoBehaviour {

    float gravity = -20.0f;
    float jumpSpeed = 10.0f;
    Vector3 velocity;

    CharacterController con;        
	// Use this for initialization
	void Start () {
        con = GetComponent<CharacterController>();
        velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        float y = transform.position.y;
        if (y < 1)
            gameObject.transform.position = new Vector3(0, 1.1f, 0);
        if (con.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
            }
        }
        velocity.y += (gravity * Time.deltaTime);
        con.Move(velocity * Time.deltaTime);

	
	}
}
