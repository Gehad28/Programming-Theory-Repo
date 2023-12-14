using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private string textContent = "Cube";

    public static string cubeColor
    {
        get
        {
            return "Dark Cyan";
        }
        set => cubeColor = value;
    }
    protected override void DisplayText()
    {
        base.DisplayText();
        text.text += textContent;
    }

}
