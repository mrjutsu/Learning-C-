using System;
using System.Collections.Generic;

namespace Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>{
                new Student() { Name = "Sally", GradeLevel = 3},
                new Student() { Name = "Bob", GradeLevel = 3},
                new Student() { Name = "Sally", GradeLevel = 2},
                new Student() { Name = "David", GradeLevel = 5},
                new Student() { Name = "Monica", GradeLevel = 6}
            };

            //students.Sort();

            //Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };

            //int index = students.BinarySearch(newStudent);

            //if (index < 0)
            //{
            //    students.Insert(~index, newStudent);
            //}

            //SchoolRoll schoolRoll = new SchoolRoll();
            //schoolRoll.AddStudents(students);

            //schoolRoll.AddStudents(students);

            //schoolRoll.Students.RemoveAt(0);
            //schoolRoll.Students.Sort();

            //schoolRoll.Students.AddRange(students);

            Student joe = new Student()
            {
                Name = "Joe",
                GradeLevel = 2
            };
            students.Add(joe);
            //Console.WriteLine(joe.GetHashCode());

            Student duplicateJoe = new Student()
            {
                Name = "Joe",
                GradeLevel = 2
            };
            students.Add(duplicateJoe);
            //Console.WriteLine(duplicateJoe.GetHashCode());

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " is in grade " + student.GradeLevel);
            }

            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name + " is in grade " + student.GradeLevel);
            //}
        }
    }
}
