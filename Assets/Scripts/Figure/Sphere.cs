using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : BaseFigure
{
    [SerializeField] private SphereCollider _collider;
    public override void SetSize(int factor)
    {
        _collider.radius = factor;
    }
}
