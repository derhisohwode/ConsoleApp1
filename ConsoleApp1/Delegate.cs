using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cragy
{
    public delegate void delly(string Message, int dev);

    public class Class16 {
        public static void Main16()
        {
            delly del = new delly(Hello);
            del("resume ", 34);

		List<Delegate> bltList = new List<Delegate>();

			bltList.Add(new Delegate() { ID = 101, Name = "Mary", Salary = 5000, experience = 5 });
			bltList.Add(new Delegate() { ID = 102, Name = "Mark", Salary = 3000, experience = 5 });
			bltList.Add(new Delegate() { ID = 103, Name = "Mare", Salary = 4000, experience = 4 });
			bltList.Add(new Delegate() { ID = 104, Name = "Marl", Salary = 6000, experience = 4 });

			Delegate.PromotedDelegate(bltList);
		}
	public static void Hello(string Message, int dev)
	{
		Console.WriteLine(Message + dev);
	}
}


class Delegate
{
	public int ID { get; set; }
	public string Name { get; set; }
	public int Salary { get; set; }
	public int experience { get; set; }

	public static void PromotedDelegate(List<Delegate> delegateList)
	{
		foreach (Delegate belegate in delegateList)
		{
			if (belegate.experience >= 5)
			{
				Console.WriteLine("promoted");
			}
		}
	}
}
}
