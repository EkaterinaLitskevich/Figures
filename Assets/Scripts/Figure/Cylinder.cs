using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseFigure
{
    public override void SetSize(int factor)
    {
        transform.localScale = new Vector3(1,factor, 1);
    }
}
