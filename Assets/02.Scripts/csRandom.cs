using UnityEngine;
using System.Collections;

public class csRandom : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int randSeedS;
        randSeedS = (int)System.DateTime.Now.Ticks;
        Random.seed= randSeedS;

        int randomX = Random.Range(5, 10);
        Debug.Log("integer : " + randomX);

        int myVal = 10;
        float nLimit = Mathf.Clamp(myVal, 1, 5);
        Debug.Log("Calmp : " + nLimit);        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
