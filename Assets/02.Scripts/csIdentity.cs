using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class csIdentity : MonoBehaviour {

    private float rotSpeed = 120.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float amtRot = rotSpeed * Time.deltaTime;
        float ang = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * ang * amtRot);

        if(Input.GetButtonDown("Fire1"))//edit -project Setting - Input
        {
            transform.localRotation = Quaternion.identity;
            ChildEnumerable children = new ChildEnumerable(transform);
            foreach (Transform a in children)
            {
                Debug.Log("foreach");
                a.localPosition = Vector3.zero;
                
                a.rotation = Quaternion.identity;
                string str = string.Format("{0} local Pos : {1} , global Pos : {2}", transform.name, a.localPosition, a.position);
                Debug.Log(str);
         
            }
        }
	
	}
}

public class ChildEnumerable: IEnumerable
{
    List<Transform> ChildList= new List<Transform>();

    public ChildEnumerable(Transform t)
    {
        int ChildCount = t.childCount;
        for(int i =0;i<ChildCount;i++)
        {
            ChildList.Add(t.GetChild(i));
        }

    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new ChildEnumerator(ChildList);
    }

    public class ChildEnumerator : IEnumerator
    {
        List<Transform> ChildList;
        int length;
        int pos = -1;
        public ChildEnumerator(List<Transform> ChildList)
        {
            this.ChildList = ChildList;
            length = ChildList.Count;

        }

        public object Current
        {
            get { return ChildList[pos]; }
        }      

        public bool MoveNext()
        {
            if (pos >= length-1 )
                return false;
            pos++;
            return true;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
