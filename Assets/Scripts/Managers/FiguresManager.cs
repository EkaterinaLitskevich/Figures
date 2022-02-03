using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

public class FiguresManager
{
    private const int MaxSize = 50;
    private const int MinSize = 1;
    
    private Cube _cube;
    private Sphere _sphere;
    private Cylinder _cylinder;

    private List<BaseFigure> _figures = new List<BaseFigure>();
    
    
    public void Init(List<GameObject> figures, Transform parent)
    {
        FiguresFactory figuresFactory = new FiguresFactory();

        for (int i = 0; i < figures.Count; i++)
        {
            var figure = figures[i];
            
            for (int j = 0; j < 5; j++)
            {
                _figures.Add(figuresFactory.Create<BaseFigure>(figure, parent));
            }
        }

        SetSizeFigures();
        SetColor();
    }

    private void SetSizeFigures()
    {
        Random random = new Random(); 
        int randomSize = 1;
        
        for (int i = 0; i < _figures.Count; i++)
        {
            Task.Run(() =>
            {
                randomSize = random.Next(MinSize, MaxSize);
            });

            _figures[i].SetSize(randomSize);
        }
    }

    private void SetColor()
    {
        RandomColor color = new RandomColor();
        Color newColor = new Color();
        
        for (int i = 0; i < _figures.Count; i++)
        {
            Task.Run(() =>
            {
                newColor = color.GetColor();
            });
            
            Debug.Log("newColor = " + newColor);
            _figures[i].SetColor(newColor);
        }
    }
}
