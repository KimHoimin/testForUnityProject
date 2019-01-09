using UnityEngine;
using System.Collections;

public class csMainScript1 : MonoBehaviour {
    public Transform firePos;
    public GameObject cannon;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(cannon, firePos.position, firePos.rotation);
        }
	
	}
}
