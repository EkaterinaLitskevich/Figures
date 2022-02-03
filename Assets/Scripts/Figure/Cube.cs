using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : BaseFigure
{
    [SerializeField] private BoxCollider _collider;
    public override void SetSize(int factor)
    {
        _collider.size = Vector3.one * factor;
    }
}
