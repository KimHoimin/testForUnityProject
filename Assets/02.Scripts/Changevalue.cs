using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Changevalue : MonoBehaviour {
    public void UpdateLabel(float value)
    {
        Text lbl = GetComponent<Text>();
        if (lbl != null)
            lbl.text = Mathf.RoundToInt(value * 10)+"%";

        Debug.Log("sdfkjsdflkj");
        Debug.Log("qnwkwlahtgodktndek");
        Debug.Log("testtest");
    }
}
