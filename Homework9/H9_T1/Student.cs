using System.Collections.Generic;
using System.Linq;

namespace H9_T1
{
    internal class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Score { get; set; }

        public Student(string name, int age, int score)
        {
            Name = name;
            Age = age;
            Score = score;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Average score: {Score}";
        }

        public static Student YongestStudent(List<Student> students)
        {
            var yongerStudent = students.FirstOrDefault();

            foreach (var student in students)
            {
                if (yongerStudent.Age > student.Age)
                {
                    yongerStudent = student;
                }
            }

            return yongerStudent;
        }
    }
}

