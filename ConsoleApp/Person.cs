using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Person
    {
        public string Name { set; get; }
        public string SecondName { set; get; }
        public DateTime DateOfBirth { set; get; }

        public Person(string name, string secondName, DateTime dateOfBirth)
        {
            Name = name;
            SecondName = secondName;
            DateOfBirth = dateOfBirth;
        }
        public int GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            return (int)(age.TotalDays / 365);
        }

    }
}
