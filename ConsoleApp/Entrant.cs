using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Entrant : Person
    {
        public int NumberOfPointsForTheCertificate { set; get; }
        public int FirstExam { set; get; }
        public int SecondExam { set; get; }
        public int ThirdExam { set; get; }
        public string SchoolName { set; get; }
      
        public Entrant(string name, string secondName, DateTime dateOfBirth, int firsExam, int secondExam, int thirdExam, int numberOfPointsForTheCertificate, string schoolName) : base(name, secondName, dateOfBirth)
        {
            FirstExam = firsExam;
            SecondExam = secondExam;
            ThirdExam = thirdExam;
            NumberOfPointsForTheCertificate = numberOfPointsForTheCertificate;
            SchoolName = schoolName;
        }
      public int GetTotalExamPoints()
        {
            return FirstExam + SecondExam + ThirdExam;
        }
    }
}
