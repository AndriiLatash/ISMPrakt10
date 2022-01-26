using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class LibraryUser : Person
    {
        public string ReadingCardNumber { set; get; }
        public DateTime DateOfIssue { set; get; }

        public string AmountOfMonthlyReadersFee { set; get; }

        public LibraryUser(string name, string secondName, DateTime dateOfBirth, string readingCardNumber, DateTime dateOfIssue, string amountOfMonthlyReadersFee) : base(name, secondName, dateOfBirth)
        {
            ReadingCardNumber = readingCardNumber;
            dateOfIssue = dateOfIssue;
            AmountOfMonthlyReadersFee = amountOfMonthlyReadersFee;
        }

    }
}
