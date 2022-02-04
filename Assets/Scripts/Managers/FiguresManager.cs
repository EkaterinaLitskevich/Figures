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

    private async void SetSizeFigures()
    {
        Random random = new Random(); 
        int randomSize = 1;
        
        for (int i = 0; i < _figures.Count; i++)
        {
            await Task.Run(() =>
            {
                randomSize = random.Next(MinSize, MaxSize);
            });

            _figures[i].SetSize(randomSize);
        }
    }

    private async void SetColor()
    {
        Random random = new Random();
        RandomColor color = new RandomColor();
        Color newColor = new Color();
        
        for (int i = 0; i < _figures.Count; i++)
        {
            await Task.Run(() =>
            {
                newColor = color.GetColor(random);
            });

            _figures[i].SetColor(newColor);
        }
    }

    private async void Check()
    {
        await CheckTwo();
    }

    private async Task<int> CheckTwo()
    {
        int value = 0;
        
        await Task.Run(() =>
        {
            value++;
        });

        return value;
    }
}
