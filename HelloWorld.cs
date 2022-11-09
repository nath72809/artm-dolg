using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private const bool V = true;

    // Start is called before the first frame update
    void Start()
    {
        bool i = V;
        if (i == V)
            print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
