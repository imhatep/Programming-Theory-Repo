using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string shapeName;
    private string shapeColor;

    private void Start()
    {
        shapeName = gameObject.name;
        shapeColor = gameObject.GetComponent<Renderer>().material.color.ToHexString();
    }

    void PrintText()
    {
        Debug.Log("Hello, i'm a " + shapeName + " (My color is " + shapeColor + " )");
        
    }

    public void OnMouseDown()
    {
        PrintText();
    }
}
