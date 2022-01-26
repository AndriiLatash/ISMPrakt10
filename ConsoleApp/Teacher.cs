using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Teacher : Person
    {
        public string Position { set; get; }
        public string Department { set; get; }
        public string UniversityName { set; get; }

        public Teacher(string name, string secondName, DateTime dateOfBirth, string position, string department, string universityName) : base(name, secondName, dateOfBirth)
        {
            Position = position;
            Department = department;
            UniversityName = universityName;
        }
    }
}
