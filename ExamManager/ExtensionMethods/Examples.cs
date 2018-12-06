using System;
using System.Collections.Generic;
using System.Text;
using MyLinQ;

namespace ExamManager.ExtensionMethods
{
    class Examples
    {
        public void StringExample()
        {
            string s = "Ciccio";
            Console.WriteLine(s);
            var sr = StringExtensions.Reverse(s);       // Metodo 1
            sr = s.Reverse();                           // Metodo 2
            Console.WriteLine(sr);
        }

    }
}
