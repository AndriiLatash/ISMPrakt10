using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Student : Person
    {
        public string Course { set; get; }
        public string Group { set; get; }

        public string Faculty { set; get; }
        public string UniversityName { set; get; }
        public Student(string name, string secondName, DateTime dateOfBirth, string course, string group, string faculty, string universityName) : base(name, secondName, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }


    }
}
