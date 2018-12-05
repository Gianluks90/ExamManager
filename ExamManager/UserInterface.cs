using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager
{
    class UserInterface
    {
        private DataProcessor processor = new DataProcessor();
        const string MENU_MESSAGE = 
            "Inserisci L per lista studenti;\n" +
            "Inserisci R per cercare tramite ID;\n" +
            "Inserisci V per la media dei voti;\n" +
            "Inserisci D per la mediana;\n" +
            "Inserisci M per la moda;\n" +
            "Inserisci S per le verifiche;\n" +
            "Inserisci Q per chiudere;";

        public void MainMenu()
        {
            Console.WriteLine(MENU_MESSAGE);
            string input = ReadAnswer();

            switch (input[0])
            {
                case 'l':
                    ShowStudents();
                    break;
                case 'r':
                    SearchStudent();
                    break;
                case 'v':
                    ShowAverage();
                    break;
                case 'd':
                    ShowMedian();
                    break;
                case 'm':
                    ShowMode();
                    break;
                case 's':
                    ShowSexistCheck();
                    break;
                case 'q':
                    return;
                default :
                    Console.WriteLine("Input non valido. Riprova.");
                    MainMenu();
                    break;
            }
        }

        private string ReadAnswer(string prompt = "")     // Default values
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        private void ShowStudents()
        {
            IEnumerable<Student> students = processor.AllStudents();
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }

        private void SearchStudent()
        {
            int id;
            string input;
            do
            {
                input = ReadAnswer("Inserire l'ID: ");
            }
            while (int.TryParse(input, out id));
            Student found = processor.FindByID(id);

            if(found!=null)
            {
                Console.WriteLine(found);
            }
            else
            {
                Console.WriteLine("Non trovato.");
            }

        }

        private void ShowAverage()
        {
            Console.WriteLine($"La media dei voti è: {processor.GetAverage()}.");
        }

        private void ShowMedian()
        {
            Console.WriteLine($"La mediana dei voti è: {processor.GetMedian()}.");
        }

        private void ShowMode()
        {
            Console.WriteLine($"La moda dei voti è: {processor.GetAverage()}.");
        }

        private void ShowSexistCheck()
        {
            bool maleSupremacy = processor.AreMaleSuperior();
            bool adultSupremacy = processor.AreAdultsSuperior();

            string m = maleSupremacy ? "sono" : "non sono";
            Console.WriteLine($"I maschi {m} superiori alle femmine.");

            string a = adultSupremacy ? "sono" : "non sono";
            Console.WriteLine($"Gli adulti {a} superiori ai minorenni.");
        }
    }
}
