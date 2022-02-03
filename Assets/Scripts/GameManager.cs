using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FiguresFatory _figuresFatory = null;
    [SerializeField] private FiguresManager _figuresManager = null;
    [SerializeField] private List<GameObject> _figures = new List<GameObject>();

    private void Start()
    {
        _figuresManager.Init(_figures, transform);
    }
}
