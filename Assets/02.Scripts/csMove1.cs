using UnityEngine;
using System.Collections;

public class csMove1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(0.0f, 0.5f, 0.0f);

        this.transform.Translate(Vector3.up*10);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
