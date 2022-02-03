using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseFigure
{
    public override void ChangeScale(int factor)
    {
        transform.localScale = Vector3.up * factor;
    }
}
