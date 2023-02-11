using System;

namespace imported
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintName()
            {
                Console.WriteLine($" Welcome! {FirstName} {LastName}");
            }

    }

    public class partTime : Employee
    {
        public float hourlyRate;
    }

    public class fullTime : Employee 
    {
        public float monthlySalary;
    }

    public class Programer
    {
        public static void Main()
        {
            Start:
            Console.WriteLine("Are you a full-time or Part-time Employee");
            string answer = Console.ReadLine().ToLower();
            if (answer == "full-time") {
                fullTime FT = new fullTime();
                Console.WriteLine("what is your first name");
                FT.FirstName = Console.ReadLine();
                Console.WriteLine("what is your last name");
                FT.LastName = Console.ReadLine();
                Console.WriteLine("How much is your Monthly salary");
                var sal = Console.ReadLine();
                FT.monthlySalary = float.Parse( sal );
                FT.PrintName();

            }
            else if (answer == "part-time")
            {
                partTime PT = new partTime();
                Console.WriteLine("what is your first name");
                PT.FirstName = Console.ReadLine();
                Console.WriteLine("what is your last name");
                PT.LastName = Console.ReadLine();
                Console.WriteLine("How much is your Monthly salary");
                var sal = Console.ReadLine();
                PT.hourlyRate = float.Parse(sal);
                PT.PrintName();

            }
            else
            {
                Console.WriteLine("Invalid answer");
                goto Start;
            }

            Employee[] e = new Employee[3];

            e[0] = new Employee();
            e[1] = new partTime();
            e[2] = new fullTime();

            foreach (Employee e2 in e)
            {
                e2.PrintName();
            }

        }
    }
}

