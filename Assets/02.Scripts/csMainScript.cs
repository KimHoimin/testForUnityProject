using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class csMainScript : MonoBehaviour
{
    GameObject box;
    string sStatus = "";

    // Use this for initialization
    void Start()
    {
        box = GameObject.Find("BattleShip");

    }

    void OnGUI()
    {
        if (GUI.RepeatButton(new Rect(10, 240, 50, 30), "<"))
        {
            sStatus = "왼쪽으로이동";
            box.transform.Translate(Vector3.left);

        }
        if(GUI.RepeatButton(new Rect(70, 240, 50, 30), ">"))
        {
            sStatus = "오른쪽으로이동";
            box.transform.Translate(Vector3.right);
        }

        if (GUI.Button(new Rect(400, 240, 50, 30), "Fire"))
        {
            sStatus = "총알발사";
            GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            bullet.transform.position = box.transform.position;
            bullet.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            bullet.name = "bullet";
            bullet.AddComponent<csBullet>();
        }//

        GUILayout.Label(sStatus);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
