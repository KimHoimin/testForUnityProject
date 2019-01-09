using UnityEngine;
using System.Collections;

public class csJump3 : MonoBehaviour
{
    float gravity = -10.0f;
    float velocityUp = 0.0f;
    Vector3 BasePosition;
    Vector3 curPos;
    // Use this for initialization
    void Start()
    {
        curPos = BasePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            velocityUp = 10.0f;
        }

        velocityUp += gravity * Time.deltaTime;
        curPos.y += velocityUp * Time.deltaTime;

        if (curPos.y < BasePosition.y)
        {
            curPos = BasePosition;
            velocityUp = 0;
        }
        Debug.Log(curPos);
        transform.position = curPos;        
    }
}
