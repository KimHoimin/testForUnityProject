using UnityEngine;
using System.Collections;

public class csRotate1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.eulerAngles = new Vector3(0.0f, 50.0f, 0.0f);

        Quaternion target = Quaternion.Euler(0.0f, 100.0f, 0.0f);

        transform.rotation = target;

        transform.Rotate(Vector3.up * 90.0f);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
