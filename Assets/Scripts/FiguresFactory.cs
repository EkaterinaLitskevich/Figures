using UnityEngine;

public class FiguresFactory 
{
   public T Create<T>(GameObject obj, Transform parent)  where T : BaseFigure
   { 
       var figure = Object.Instantiate(obj, parent).GetComponent<T>();
       return figure;
   }
}
