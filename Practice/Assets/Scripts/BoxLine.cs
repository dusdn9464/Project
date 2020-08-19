using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class BoxLine : MonoBehaviour
{
    LineRenderer lr;
    Vector3 exBoxPos, conBoxPos;
    public float lineSize = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.startWidth = lineSize;
        lr.endWidth = lineSize;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.hasChanged)
        {
            exBoxPos = gameObject.GetComponent<Transform>().position;
            transform.hasChanged = false;
        }

        lr.SetPosition(0, exBoxPos);
        lr.SetPosition(1, GameObject.Find("Engine").GetComponent<Transform>().position);
    }
}
