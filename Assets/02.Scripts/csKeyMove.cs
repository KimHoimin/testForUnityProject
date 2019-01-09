using UnityEngine;
using System.Collections;

public class csKeyMove : MonoBehaviour {
    public csRandom a = new csRandom();
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(
            Input.GetAxis("Vertical")*10.0f*1,
            0,
            Input.GetAxis("Horizontal") * 10.0f * -1);	
	}
}
