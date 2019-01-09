using UnityEngine;
using System.Collections;

public class csCannon : MonoBehaviour {
    float power = 900.0f;
    Vector3 vel = new Vector3(0.0f, 0.3f, 0.5f);
	// Use this for initialization
	void Start () {
        vel *= power;
        GetComponent<Rigidbody>().AddForce(vel);
	
	}
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.z>10.0f)
        {
            Destroy(this.gameObject);
        }
	
	}
}
