using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float x;

    // Start is called before the first frame update
    void Start()
    {
        // We can output the result of a function like this 
        Debug.Log(Check1000(10, 500)); // this should output true because 10 * 500 = 5000 > 1000

        //Or we can put the result inside a variable that matches the type of the function
        bool b = Check1000(5, 10); // The variable b holds false because 5 * 10 = 50 < 1000
    }
    int Sum(
    int a, int b)
    {
        return a + b;
    }
    bool Check1000(float x, float y)
    {
        float z = x * y;
        return z > 1000;
    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         x++;
        Debug.Log("x");
    }

    void DoStuff()
    {
        Debug.Log("Hello world!");
    }


}

// Update is called once per frame
