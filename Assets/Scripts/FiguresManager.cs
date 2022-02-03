using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguresManager 
{
    private void Init()
    {
        FiguresFatory<Cube> _cubeFatory = new FiguresFatory<Cube>();
        Cube _cube = _cubeFatory.Creat();
        
        FiguresFatory<Sphere> _sphereFatory = new FiguresFatory<Sphere>();
        Sphere _sphere = _sphereFatory.Creat();
        
        FiguresFatory<Cylinder> _cylinderFatory = new FiguresFatory<Cylinder>();
        Cylinder _cylinder = _cylinderFatory.Creat();
    }
}
