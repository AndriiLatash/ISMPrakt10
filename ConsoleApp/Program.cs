using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = Person  2 = Entrant  3 = Student  4 = Teacher  5 = Library user");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Number of people = ");
                    int a = int.Parse(Console.ReadLine());
                    Person[] persons = new Person[a];
                    for (int i = 0; i < persons.Length; i++)
                    {
                        Console.WriteLine("Name = ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Second name = ");
                        string secondName = Console.ReadLine();
                        Console.WriteLine("Year = ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Month = ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Day = ");
                        int day = int.Parse(Console.ReadLine());
                        persons[i] = new Person(name, secondName, new DateTime(year, month, day));

                    }
                    break;
                case 2:
                    Console.WriteLine("Number of entrants = ");
                    int b = int.Parse(Console.ReadLine());
                    Entrant[] entrants = new Entrant[b];
                    for (int i = 0; i < entrants.Length; i++)
                    {
                        Console.WriteLine("Name = ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Second name = ");
                        string secondName = Console.ReadLine();
                        Console.WriteLine("Year = ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Month = ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Day = ");
                        int day = int.Parse(Console.ReadLine());
                        Console.WriteLine("Number Of Points For The Certificate =");
                        int numberOfPointsForTheCertificate = int.Parse(Console.ReadLine());
                        Console.WriteLine("Points for the first exam = ");
                        int firstExam = int.Parse(Console.ReadLine());
                        Console.WriteLine("Points for the second exam = ");
                        int secondExam = int.Parse(Console.ReadLine());
                        Console.WriteLine("Points for the third exam = ");
                        int thirdExam = int.Parse(Console.ReadLine());
                        Console.WriteLine("School name = ");
                        string schoolName = Console.ReadLine();
                        entrants[i] = new Entrant(name, secondName, new DateTime(year, month, day), numberOfPointsForTheCertificate, firstExam, secondExam, thirdExam, schoolName);
                    }
                    break;

                case 3:
                    Console.WriteLine("Number of students = ");
                    int c = int.Parse(Console.ReadLine());
                    Student[] students = new Student[c];
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("Name = ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Second name = ");
                        string secondName = Console.ReadLine();
                        Console.WriteLine("Year = ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Month = ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Day = ");
                        int day = int.Parse(Console.ReadLine());
                        Console.WriteLine("Course = ");
                        string course = Console.ReadLine();
                        Console.WriteLine("Group = ");
                        string group = Console.ReadLine();
                        Console.WriteLine("Faculty = ");
                        string faculty = Console.ReadLine();
                        Console.WriteLine("University name = ");
                        string universityName = Console.ReadLine();
                        students[i] = new Student(name, secondName, new DateTime(year, month, day), course, group, faculty, universityName);
                    }
                    break;
                case 4:
                    Console.WriteLine("Number of teachers = ");
                    int d = int.Parse(Console.ReadLine());
                    Teacher[] teachers = new Teacher[d];
                    for (int i = 0; i < teachers.Length; i++)
                    {
                        Console.WriteLine("Name = ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Second name = ");
                        string secondName = Console.ReadLine();
                        Console.WriteLine("Year = ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Month = ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Day = ");
                        int day = int.Parse(Console.ReadLine());
                        Console.WriteLine("Position = ");
                        string position = Console.ReadLine();
                        Console.WriteLine("Department = ");
                        string department = Console.ReadLine();
                        Console.WriteLine("University Name = ");
                        string universityName = Console.ReadLine();
                        teachers[i] = new Teacher(name, secondName, new DateTime(year, month, day), position, department, universityName);
                    }
                        break;
                case 5:
                    Console.WriteLine("Number of libraryUsers = ");
                    int e = int.Parse(Console.ReadLine());
                    LibraryUser[] libraryUsers = new LibraryUser[e];
                    for (int i = 0; i < libraryUsers.Length; i++)
                    {
                        Console.WriteLine("Name = ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Second name = ");
                        string secondName = Console.ReadLine();
                        Console.WriteLine("Year = ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Month = ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Day = ");
                        int day = int.Parse(Console.ReadLine());
                        Console.WriteLine("Reading Card Number = ");
                        string readingCardNumber = Console.ReadLine();
                        Console.WriteLine("DateOfIssue :");
                        Console.WriteLine("Year = ");
                        int year1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Month = ");
                        int month1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Day = ");
                        int day1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("AmountOfMonthlyReadersFee = ");
                        string amountOfMonthlyReadersFee = Console.ReadLine();
                        libraryUsers[i] = new LibraryUser(name, secondName, new DateTime(year, month, day), readingCardNumber, new DateTime(year1, month1, day1), amountOfMonthlyReadersFee);
                    }

                    break;
                    }

        }
    }
}
