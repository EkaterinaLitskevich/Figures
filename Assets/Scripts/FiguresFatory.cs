using UnityEngine;

public class FiguresFatory : MonoBehaviour
{
   public T Create<T>(GameObject obj, Transform parent)  where T : MonoBehaviour
   { 
       var figure = Instantiate(obj, parent).GetComponent<T>();
       return figure;
   }
}
