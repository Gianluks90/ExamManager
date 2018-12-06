using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.ExtensionMethods
{
    static class MyLinQ     // I metodi di estensione devono essere " statici ";
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var x in source)      // Per ogni elemento x della sequenza source;
            {
                if(predicate(x))
                {
                    yield return x;
                }
            }
        }
    }
}
