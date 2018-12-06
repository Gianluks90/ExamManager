using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamManager
{
    class DataSource
    {
        private string path;

        public DataSource(string v)
        {
            this.path = path;
        }

        public IEnumerable<Student> AllStudents()
        {
            return File.ReadLines(path)
                .Select(line => new Student(line.Split(","))).ToList();
        }
    }
}
