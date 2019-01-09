using UnityEngine;
using System.Collections;

public class csRotate2 : MonoBehaviour {
    float speed = 50.0f;

	// Use this for initialization
	void Start () {
        if(gameObject.name =="Cube")
        {
          //  transform.rotation =Quaternion.AngleAxis(30,Vector3.up)* Quaternion.AngleAxis(90, Vector3.right) * Quaternion.AngleAxis(45, Vector3.forward);
        }
        else
        {

            /* Quaternion target = Quaternion.Euler(90.0f, 30.0f, 45.0f);
             transform.rotation = target;*/
            //  transform.Rotate(new Vector3(90.0f, 30.0f, 45.0f));
         //   transform.Rotate(new Vector3(90.0f, 30.0f, 45.0f), Space.World);
          /*  transform.Rotate(Vector3.up * 30);
            transform.Rotate(Vector3.right * 90);
           
            transform.Rotate(Vector3.forward * 45);*/
        }
        
       // transform.rotation *=   Quaternion.AngleAxis(90, Vector3.forward)* Quaternion.AngleAxis(90, Vector3.right);


    }

    // Update is called once per frame
    void Update () {
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        float h = 5.0f;
        float v = 2.121f;

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        if(gameObject.name == "Cube")
        //if(true)
        {

            //transform.rotation *= Quaternion.AngleAxis(h, Vector3.forward);
            transform.Rotate(v, 0, h);
            Debug.Log("cube Rotation" + transform.rotation.eulerAngles);
           
            
            //  transform.rotation *= Quaternion.AngleAxis(v, Vector3.right);
        }
        else if(gameObject.name == "Cube2")
        {
            //transform.rotation = Quaternion.AngleAxis(h, Vector3.forward)*transform.rotation;
            //transform.rotation = Quaternion.AngleAxis(v, Vector3.right)*transform.rotation;

            
            transform.Rotate(Vector3.right * v);
            transform.Rotate(Vector3.forward * h);
            Debug.Log("cube2 Rotation" + transform.rotation.eulerAngles);
        }
        
	
	}
}
