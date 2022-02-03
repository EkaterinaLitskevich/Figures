using UnityEngine;

public abstract class BaseFigure : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    
    public Material Material
    {
        get => _meshRenderer.material;
        set => _meshRenderer.material = value;
    }

    public virtual void SetSize(int factor)
    {
        transform.localScale = Vector3.one * factor;
    }
}
