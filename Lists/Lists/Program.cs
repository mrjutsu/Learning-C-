using System;
using System.Collections.Generic;

namespace Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student() { Name = "Sally", GradeLevel = 3},
                new Student() { Name = "Bob", GradeLevel = 3},
                new Student() { Name = "Sally", GradeLevel = 2},
                new Student() { Name = "David", GradeLevel = 5},
                new Student() { Name = "Monica", GradeLevel = 6}
            };

            students.Sort();

            Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };

            int index = students.BinarySearch(newStudent);

            if (index < 0)
            {
                students.Insert(~index, newStudent);
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " is in grade " + student.GradeLevel);
            }
        }
    }
}
