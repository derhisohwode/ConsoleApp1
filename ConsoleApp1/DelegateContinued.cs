using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;




public class Class17 {
        public static void Main17()
        {
		List<Employee> bltList = new List<Employee>();

			bltList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, experience = 5 });
			bltList.Add(new Employee() { ID = 102, Name = "Mark", Salary = 3000, experience = 5 });
			bltList.Add(new Employee() { ID = 103, Name = "Mare", Salary = 4000, experience = 4 });
			bltList.Add(new Employee() { ID = 104, Name = "Marl", Salary = 6000, experience = 4 });

			isPromotable isPromotable = new isPromotable(Promote);

			Employee.PromoteEmployee(bltList, isPromotable);
		}

		static bool Promote(Employee emp)
		{
			if (emp.experience >= 5)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

delegate bool isPromotable(Employee empl);
class Employee
{
	public int ID { get; set; }
	public string? Name { get; set; }
	public int Salary { get; set; }
	public int experience { get; set; }

	public static void PromoteEmployee(List<Employee> employeeList, isPromotable isEligibleToPromote)
	{
		foreach (Employee employee in employeeList)
		{
			if (isEligibleToPromote(employee))
			{
				Console.WriteLine(employee.Name + " promoted");
			}
		}
	}
}

///////////////////////////////////////////OR////////////////////////////////////////

public class Class18
{
	public static void Main18()
	{
		List<Employee> bltList = new List<Employee>();

		bltList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, experience = 5 });
		bltList.Add(new Employee() { ID = 102, Name = "Mark", Salary = 3000, experience = 5 });
		bltList.Add(new Employee() { ID = 103, Name = "Mare", Salary = 4000, experience = 4 });
		bltList.Add(new Employee() { ID = 104, Name = "Marl", Salary = 6000, experience = 4 });

		//usiing lambda expression

		Employee.PromoteEmployee(bltList, emp => emp.experience >= 5);
	}

	
}

delegate bool isPromotable1(Employee empl);
class Employee1
{
	public int ID { get; set; }
	public string? Name { get; set; }
	public int Salary { get; set; }
	public int experience { get; set; }

	public static void PromoteEmployee(List<Employee> employeeList, isPromotable isEligibleToPromote)
	{
		foreach (Employee employee in employeeList)
		{
			if (isEligibleToPromote(employee))
			{
				Console.WriteLine(employee.Name + " promoted");
			}
		}
	}
}
