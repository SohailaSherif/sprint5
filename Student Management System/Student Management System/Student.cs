using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    internal class Student : Person
    {
        private double _gpa;
        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0 || value > 4)
                {
                    throw new ArgumentException("GPA must be between 0 and 4");
                }
                _gpa = value;
            }
        }
        public static int StudentCount { get; private set; }

        public Student() : base()
        {
            _gpa = 0.0;
            StudentCount++;
        }
        public Student(string name, int age, double gpa) : base(name, age)
        {
            GPA = gpa;
            StudentCount++;
        }
        public Student(Student student) : base(student)
        {
            _gpa = student._gpa;
            StudentCount++;
        }
        public string CalculateGrade()
        {
            if (_gpa >= 3.5)
            {
                return "Excellent";
            }
            else if (_gpa >= 3.0)
            {
                return "Very Good";
            }
            else if (_gpa >= 2.5)
            {
                return "Good";
            }
            else if (_gpa >= 2.0)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"GPA: {_gpa}");
            Console.WriteLine($"Grade: {CalculateGrade()}");
        }
    }
}
