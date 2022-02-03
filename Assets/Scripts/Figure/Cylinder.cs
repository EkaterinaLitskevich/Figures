using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseFigure
{
    [SerializeField] private CapsuleCollider _collider;
    public override void SetSize(int factor)
    {
        _collider.height = factor;
    }
}
