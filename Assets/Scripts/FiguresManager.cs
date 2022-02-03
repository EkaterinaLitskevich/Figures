using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguresManager
{
    private Cube _cube;
    private Sphere _sphere;
    private Cylinder _cylinder;
    
    public void Init(List<GameObject> figures, Transform parent)
    {
        FiguresFatory figuresFatory = new FiguresFatory();
        
        for (int i = 0; i < figures.Count; i++)
        {
            if (figures[i].GetComponent<Cube>())
            {
                _cube = figuresFatory.Create<Cube>(figures[i], parent);
            }
            if (figures[i].GetComponent<Sphere>())
            {
                _sphere = figuresFatory.Create<Sphere>(figures[i], parent);
            }
            if (figures[i].GetComponent<Cylinder>())
            {
                _cylinder = figuresFatory.Create<Cylinder>(figures[i], parent);
            }
        }
    }
}
