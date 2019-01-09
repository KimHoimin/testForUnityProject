using UnityEngine;
using System.Collections;

public class csThrow1 : MonoBehaviour
{
    float power = 400.0f;
    Vector3 velocity = new Vector3(0.5f, 0.5f, 0.5f);

    void Start()
    {
        velocity *= power;
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //velocity = velocity + power;

            GetComponent<Rigidbody>().AddForce(velocity);

        }
    }
}
