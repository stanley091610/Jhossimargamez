using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class variableandfunction : MonoBehaviour
{
    //Create a variable of type integer
    int myInt = 7;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run myint thru my function to multiply it by two
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);

    }

    // Update is called once per frame
    void Update()
    {

    }





    //creating a function that take a int parameter and multiplies it by 2
    int MultiplyByTwo(int number)
    {
        //creating a variable to store my resuls
        int results;
        //multiplying the passed parameter by 2 
        results = number * 2;
        return results;

    }
}