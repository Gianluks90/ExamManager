using ExamManager.Closure;
using System;

namespace ExamManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbSource = new DBDataSource();
            //var proc = new DataProcessor(dbSource);

            //var UI = new UserInterface(proc);
            //UI = new UserInterface(new DataProcessor(new DBDataSource()));

            //UI.MainMenu();

            EsempioClosure esempio = new EsempioClosure();
            Func<string, bool> myClosure = esempio.GenerateMyFunction();
        }
    }
}
