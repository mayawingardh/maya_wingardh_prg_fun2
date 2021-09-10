using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : ProcessingLite.GP21 
{
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        Circle(x, y, 0.2f);
    }
}
