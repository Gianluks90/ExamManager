using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager
{
    enum Sex { M, F, C }

    class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Sex Gender { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return $"ID: {id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Gender: {Gender}, Grade: {Grade}";
        }
    }
}
