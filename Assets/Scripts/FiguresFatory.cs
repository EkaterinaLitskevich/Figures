using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguresFatory<T> where T: BaseFigure, new()
{
   public T Creat()
   {
      return new T();
   }
}
