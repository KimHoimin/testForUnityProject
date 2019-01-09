using UnityEngine;
using System.Collections;

public class csCollisionMove : MonoBehaviour {
    float speed = 20.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

       // Debug.Log(h + v);
        this.transform.Translate(Vector3.right * h);
        this.transform.Translate(Vector3.forward * v);
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 500, 0));
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    //Is Triiger check box 가 켜지면 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.AddForce(new Vector3(0, 600, 0));
    }
        
}
