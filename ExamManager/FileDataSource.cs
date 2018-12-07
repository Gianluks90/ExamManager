using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamManager
{
    public class FileDataSource : DataSource
    {
        private string path;
        private List<Student> students;

        public FileDataSource(string v)
        {
            this.path = path;
        }

        public IEnumerable<Student> AllStudents()
        {
            if(students == null)
            {
                students = File.ReadLines(path)
                .Select(line => new Student(line.Split(","))).ToList();
            }
            return students;
        }
    }
}
