using UnityEngine;
using System.Collections;

public class csRotateAround : MonoBehaviour {
    Transform obj = null;


	// Use this for initialization
	void Start () {

        obj = GameObject.Find("Cube1").transform;
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.RotateAround(obj.position, Vector3.up, 40 * Time.deltaTime);
        transform.LookAt(obj);
	}
}
