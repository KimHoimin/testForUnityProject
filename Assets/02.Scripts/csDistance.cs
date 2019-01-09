using UnityEngine;
using System.Collections;

public class csDistance : MonoBehaviour {
    public Transform box1;
    public Transform box2;
    public Transform box3;

    // Use this for initialization
    void Start () {
        float distance1 = Vector3.Distance(transform.position, box2.position);
        Debug.Log("distance1 : " + distance1);

        float distance2 = (box3.position - transform.position).magnitude;
        Debug.Log("distance2 : " + distance2);

        Vector3 dir = box2.position - transform.position;
        dir.Normalize();

        transform.eulerAngles = dir;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
