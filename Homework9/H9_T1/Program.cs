using System;
using System.Collections.Generic;

namespace H9_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var studentList = new List<Student>
                {
                    new Student("Denis", 17, 10),
                    new Student("Misha", 16, 8),
                    new Student("Ksenia", 18, 9),
                    new Student("Roman", 17, 9),
                };
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();

            studentList.Sort((student1, student2) => student2.Score.CompareTo(student1.Score));

            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();

            var yongestStudent = Student.YongestStudent(studentList);

            Console.WriteLine(yongestStudent.ToString());
        }
    }
}
