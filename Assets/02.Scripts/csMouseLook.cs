using UnityEngine;
using System.Collections;

public class csMouseLook : MonoBehaviour {
    public float sensitivity = 500.0f;
    public float rotX;
    public float rotY;

    // Use this for initialization
    void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        float mouseMoveValueY = Input.GetAxis("Mouse Y");

        rotX += mouseMoveValueX * sensitivity * Time.deltaTime;
        rotY += mouseMoveValueY * sensitivity * Time.deltaTime;

        if (rotY > 45.0f)
            rotY = 45.0f;
        if (rotY < -20.0f)
            rotY = -20.0f;

        transform.eulerAngles = new Vector3(-rotY, rotX, 0.0f);


    }
}
