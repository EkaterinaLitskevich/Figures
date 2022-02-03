using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _figures = new List<GameObject>();

    private void Start()
    {
        FiguresManager figuresManager = new FiguresManager();
        figuresManager.Init(_figures, transform);
    }
}
