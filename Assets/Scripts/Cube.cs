using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : BaseFigure
{
    private void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
