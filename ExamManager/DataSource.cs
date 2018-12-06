using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager
{
    class DataSource
    {
        private string v;

        public DataSource(string v)
        {
            this.v = v;
        }

        internal IEnumerable<Student> AllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
