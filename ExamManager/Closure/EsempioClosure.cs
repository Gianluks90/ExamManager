using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Closure
{
    class EsempioClosure
    {
        public Func<string, bool> GenerateMyFunction()      // " Func<string, bool> " è il TIPO di ritorno di questa funzione;
        {
            string name = "Ciccio";
            return s => s == name;
        }


    }
}
