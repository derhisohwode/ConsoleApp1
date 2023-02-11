using System;

namespace imported
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public virtual void PrintName() //method
            {
                Console.WriteLine($" Welcome! {FirstName} {LastName}");
            }

    }

    public class partTime : Employee //inheritance
    {
        public float hourlyRate;

		public new void PrintName() //polymorphism(new method)
        {
			Console.WriteLine($"  {FirstName} {LastName}Welcome!");
		}
	}

    public class fullTime : Employee 
    {
        public float monthlySalary;

        public override void PrintName() //polymorphism(override method)
        {
            Console.WriteLine($"  {FirstName} {LastName}you are Welcome!");
        }
    }

    public class Programer
    {
        public static void Main()
        {
            //Start: //label

            fullTime FT = new fullTime();
                Console.WriteLine("what is your first name");
                FT.FirstName = Console.ReadLine();
                Console.WriteLine("what is your last name");
                FT.LastName = Console.ReadLine();
                Console.WriteLine("How much is your Monthly salary");
                var sal = Console.ReadLine();
                FT.monthlySalary = float.Parse( sal );
                FT.PrintName();

				
                partTime PT = new partTime();
                Console.WriteLine("what is your first name");
                PT.FirstName = Console.ReadLine();
                Console.WriteLine("what is your last name");
                PT.LastName = Console.ReadLine();
                Console.WriteLine("How much is your Monthly salary");
                var sal1 = Console.ReadLine();
                PT.hourlyRate = float.Parse(sal1);
                PT.PrintName();

				Employee[] e = new Employee[3]; //array

            e[0] = new Employee();
				e[1] = PT;
				e[2] = FT;

				foreach (Employee e2 in e) //foreach loop
				{
					e2.PrintName();
				}

		
                //goto Start;
            //Employee[] e = new Employee[3];

            //e[0] = new Employee();
            //e[1] = new partTime();
            //e[2] = new fullTime();

            //foreach (Employee e2 in e)
            //{
            //    e2.PrintName();
            //}

        }
    }
}

