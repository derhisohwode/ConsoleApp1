using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public delegate void SimpleDelegate(); 
public delegate int SimpleDelegate1(); 
public delegate void SimpleDelegate2(out int integer); 
public class Class19
{
	public static void Main19()
	{
		SimpleDelegate del, del2, del3, del4;
		SimpleDelegate1 del5;
		SimpleDelegate2 del6;
		del = new SimpleDelegate(SimpleMethod);
		del2 = new SimpleDelegate(SimpleMethod2);
		del3 = new SimpleDelegate(SimpleMethod3);
		del5 = new SimpleDelegate1(SimpleMethod1);
		del6 = new SimpleDelegate2(SimpleMethod6);
		del();
		del2();
		del3();
		del4 = del + del2 + del3;
		del4();
		int print = del5();
		int num;
		del6(out num);
		Console.WriteLine("{0} & {1} ",print, num);

		///////////////////////////////OR//////////////////////////////////////
		
		//del += new SimpleDelegate(SimpleMethod);
		//del += new SimpleDelegate(SimpleMethod2);
		//del += new SimpleDelegate(SimpleMethod3);

		//del();
	}
	public static void SimpleMethod()
	{
		Console.WriteLine("Simplemethod invoked");
	}
	public static int SimpleMethod1()
	{
		return 1;
	}
	public static void SimpleMethod6(out int number)
	{
		number = 10;
	}
	public static void SimpleMethod2()
	{
		Console.WriteLine("Simplemethod2 invoked");
	}
	public static void SimpleMethod3()
	{
		Console.WriteLine("Simplemethod3 invoked");
	}
}


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
