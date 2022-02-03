using System;
using UnityEngine;

public abstract class BaseFigure : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    public virtual void SetSize(int factor){}

    public void SetColor(Color color)
    {
        _meshRenderer.material.color = color;
    }
}
