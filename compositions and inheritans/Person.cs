using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compositions_and_inheritans
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void PersonDetails()
        {
            Console.WriteLine("Name: ", Name);
            Console.WriteLine("Age: ", Age);
            Console.WriteLine("Address: ", Address);
        }
    }
    class Student : Person
    {
        public int StudentID { get; set; }
        public string GradeLevel { get; set; }

        public Student(string name, int age, string address, int studentID, string gradeLevel)
            : base(name, age, address)
        {
            StudentID = studentID;
            GradeLevel = gradeLevel;
        }

        public void StudentDetails()
        {
            PersonDetails();
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Grade Level: " + GradeLevel);
        }
    }
    class Teacher : Person
    {
        public int TeacherID { get; set; }
        public List<string> Subjects { get; set; }

        public Teacher(string name, int age, string address, int teacherID, List<string> subjects)
            : base(name, age, address)
        {
            TeacherID = teacherID;
            Subjects = subjects;
        }

        public void TeacherDetails()
        {
            PersonDetails();
            Console.WriteLine("Teacher ID: " + TeacherID);
            Console.WriteLine("Subjects: ");
            foreach (string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public void AssignSubjects(List<string> subjects)
        {
            Subjects = subjects;
        }
    }


}
