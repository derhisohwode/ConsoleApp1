using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface Icustomer : Impish, Impish1
{
	void Display();
}

interface Impish
{
	void dd();
}
interface Impish1
{
	void dd();
}

public class imple : Icustomer
{
	public void Display() {
		Console.WriteLine("display");
	}
	void Impish.dd()
	{
		Console.WriteLine("displayed");
	}
	void Impish1.dd()
	{
		Console.WriteLine("displayer");
	}
}

	public class ClassInterface
	{
		public static void Main8()
		{
		imple d;
		d = new imple();
		d.Display();
		((Impish)d).dd(); 
		((Impish1)d).dd();
		}
	}
