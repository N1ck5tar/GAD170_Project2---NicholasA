using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public bool test1 = true;
    public int test2 = 2;
    public string test3 = "three";
    public float test4 = 4.4f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Light is: " + test1);
        Debug.Log("Light count is: " + test4);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
