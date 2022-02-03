using System.Collections;
using System;
using UnityEngine;
using Random = System.Random;

public class RandomColor 
{
    private const int MinValue = 0;
    private const int MaxValue = 255;
    
    public Color GetColor()
    {
        Random random = new Random();
        int r = random.Next(MinValue, MaxValue + 1);
        int g = random.Next(MinValue, MaxValue + 1);
        int b = random.Next(MinValue, MaxValue + 1);

        Color color = new Color(r, g, b);

        return color;
    }
}
