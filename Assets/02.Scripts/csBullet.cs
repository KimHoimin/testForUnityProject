using UnityEngine;
using System.Collections;

public class csBullet : MonoBehaviour {
    float Speed = 10.0f;
		
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * Speed * Time.deltaTime);
        if(this.transform.position.y>10.0f)
        {
            Destroy(this.gameObject);
        }
	
	}
}
