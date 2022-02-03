using System.Collections;
using System;
using UnityEngine;
using Random = System.Random;

public class RandomColor 
{
    private const int MinValue = 0;
    private const int MaxValue = 1;
    
    public Color GetColor(Random random)
    {
        float r = (float)random.NextDouble();
        float g = (float)random.NextDouble();
        float b = (float)random.NextDouble();

        Color color = new Color(r, g, b, 1);

        return color;
    }
}
