using UnityEngine;
using System.Collections;

public class csScreenPointMove : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        
        //if(Input.GetButtonUp("Fire1"))
        if(Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //Debug.DrawRay(Camera.main.transform.position, ray.direction, Color.red);
            if(Physics.Raycast(ray,out hit))
            {
                Debug.DrawRay(Camera.main.transform.position, ray.direction*8, Color.red);
                Vector3 newPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                transform.position = newPos;
                //transform.eulerAngles = (transform.position - GameObject.Find("test").transform.position).normalized;


                //transform.eulerAngles = new Vector3(20, 10, 60);
                transform.eulerAngles = ray.direction.normalized;
                Debug.Log(transform.eulerAngles);
                Debug.Log(hit.collider.name);
            }

        }
	
	}
}
