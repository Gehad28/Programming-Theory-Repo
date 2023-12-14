using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Canvas : MonoBehaviour
{
    public TextMeshProUGUI color;

    private void Start()
    {
        color.text = "";
    }

    public void displayColor(string shape)
    {
        if (shape == "Cube")
        {
            color.text = Cube.cubeColor;
        }
        else if (shape == "Sphere")
        {
            color.text = Sphere.sphereColor;
        }
        else
        {
            color.text = Capsule.capsuleColor;
        }
    }
}
