using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamManager
{
    class DataProcessor
    {
        private DataSource source = new DataSource("Data/Studenti.csv");
        private int id;
        private Func<Student, bool> predicate;
               
        public IEnumerable<Student> AllStudents()
        {
            return source.AllStudents();
        }

        public Student FindByID(int id)
        {
            /*var ss = source.AllStudents();
            //predicate = HasID;
            //this.id = id;
            //Enumerable.SingleOrDefault(s, predicate);
            IEnumerable<Student> fs = from o in ss where o.id == id select o;              // Sintassi SQL;
            Student f = fs.SingleOrDefault();
            Student x = ss.Where(y => y.id == id).SingleOrDefault();
            Student found = ss.SingleOrDefault((Student s) => s.id == id);                // Lambda expression;
            return found;*/

            var ss = source.AllStudents();
            return source.AllStudents().SingleOrDefault(s => s.id == id);
        }

        private bool HasID(Student student)
        {
            return student.id == id;
        }

        public bool AreMaleSuperior()       // true se il minimo voto dei maschi è maggiore del massimo delle femmine
        {
            /*var m = source.AllStudents()            // Questa è una...
                .Where(s => s.Gender == Sex.M)
                .OrderBy(s=> s.Grade)
                .First()
                .Grade;
            var f = source.AllStudents()
                .Where(s => s.Gender == Sex.F)
                .OrderBy(s => s.Grade)
                .Last().
                Grade;
            return m > f;*/
            return source.AllStudents()
                    .Where(s => s.Gender == Sex.M)
                    .Min(s => s.Grade) >
                    source.AllStudents()
                    .Where(s => s.Gender == Sex.F)
                    .Max(s => s.Grade);
        }

        public bool AreAdultsSuperior()
        {
            return source.AllStudents()
                .Where(s => s.Age > 18)
                .GroupBy(g => g.Grade)
                .OrderByDescending(w => w.Count())
                .First()
                .Key >
                source.AllStudents()
                .Where(s => s.Age < 18)
                .GroupBy(g => g.Grade)
                .OrderByDescending(w => w.Count())
                .First()
                .Key;
        }

        public double GetAverage()
        {
            return source.AllStudents().Average(s => s.Grade);
        }

        public double GetMedian()
        {
            List<Student> r = source.AllStudents().OrderBy(s => s.Grade).ToList();
            double median;
            if (r.Count%2 == 0)     // Alternativamente : ((r.Count & 1) == 0) 
            {
                median = (r[r.Count/2].Grade + r[r.Count/2 -1].Grade) / 2;
            }
            else
            {
                median = r[r.Count / 2].Grade;
            }
            return median;
        }

        internal object GetMode()
        {
            return source.AllStudents()
                .GroupBy(s => s.Grade)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
        }
    }
}
