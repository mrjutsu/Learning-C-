using System;
using System.Collections.Generic;

namespace Lists
{
    public class SchoolRoll
    {
        private HashSet<Student> _students = new HashSet<Student>();

        public IEnumerable<Student> Students { get { return _students; } }

        public void AddStudents(IEnumerable<Student> students)
        {
            _students.UnionWith(students);
            //_students.AddRange(students);
        }
    }
}
