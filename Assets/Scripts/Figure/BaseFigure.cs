using System;
using UnityEngine;

public abstract class BaseFigure : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    public virtual void SetSize(int factor)
    {
        transform.localScale = Vector3.one * factor;
    }

    public void SetColor(Color color)
    {
        _meshRenderer.material.SetColor(1, color); 
    }
}
