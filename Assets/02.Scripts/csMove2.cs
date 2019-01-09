using UnityEngine;
using System.Collections;

public class csMove2 : MonoBehaviour {
    float speed = 20.0f;

	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;
        
        Debug.Log(h + v);
        this.transform.Translate(Vector3.right * h);
        this.transform.Translate(Vector3.forward * v);
	
	}
}
