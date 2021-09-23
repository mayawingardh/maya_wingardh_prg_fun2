using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assigment1 : ProcessingLite.GP21
{
    float spaceBetweenLines = 0.4f;
    public float x;
    public float y;
    public float x1;
    public float y1;
 
    void Start()
    {
        // Colours and size
        Background(143, 188, 143);
        StrokeWeight(1f);
        Stroke(85, 105, 47);

        int lines = 10;

        //Draw background
        for (int i = 0; i < lines; i++)
        {
            float y = i * spaceBetweenLines;
            Line(6.91f - y, 1.68f + y, 11.39f - y, 5.7f + y);
        }
    }

    void Update()
    {
        StartCoroutine(wait());
        
    }

        //method for writings the letters one by one.
        IEnumerator wait()      
        {
            StrokeWeight(1.4f);
            yield return new WaitForSeconds(0.5f);
            Line(4.15f, 4.51f, 4.39f, 5.54f);
            yield return new WaitForSeconds(0.5f);
            Line(4.39f, 5.54f, 5.27f, 4.77f);
            yield return new WaitForSeconds(0.5f);
            Line(5.27f, 4.77f, 7.67f, 9.8f);
            yield return new WaitForSeconds(0.5f);
            Line(7.67f, 9.8f, 6.96f, 1.31f);
            yield return new WaitForSeconds(0.5f);
            Line(6.96f, 1.31f, 8.75f, 4.84f);
            yield return new WaitForSeconds(0.5f);
            Line(8.75f, 4.84f, 9.86f, 4.16f);
            yield return new WaitForSeconds(0.5f);
            Line(9.86f, 4.16f, 10.58f, 6.52f);

        }

}

