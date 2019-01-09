using UnityEngine;
using System.Collections;

public class csJump2 : MonoBehaviour {

    public int a = 0;

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 400, 0));
        }
    }
}
