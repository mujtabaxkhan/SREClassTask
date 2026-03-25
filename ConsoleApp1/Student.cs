using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private string name;
        private string id;
        private int grade;
        private string section;

        public Student(string name, string id, int grade, string section)
        {
            this.name = name;
            this.id = id;
            this.grade = grade;
            this.section = section;
        }

        public void getStudent()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Id: " + id);
            Console.WriteLine("Student Grade: " + grade);
            Console.WriteLine("Student Section: " + section);
        }
    }
}
