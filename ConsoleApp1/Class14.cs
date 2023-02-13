using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
	public struct study
	{
		private int _id;
		private string _Name;



		public int Id
		{
			get { return this._id; }
			set { this._id = value; }
		}

		public string Name
		{
			get { return this._Name; }
			set { this._Name = value; }
		}
		public study(int Id, string Name)
		{
			this._id = Id;
			this._Name = Name;
		}

		public void PrintInfo()
		{
			Console.WriteLine("Dear {0}, your Name is {1}", this._id, this._Name);
		}
	}

		public class Class14
		{
			public static void Main7()
			{
				study S1 = new study();
				S1.Id = 111;
				S1.Name = "101";
				S1.PrintInfo();
				

				//Console.WriteLine("Dear {0}, your ID is {1} and PassMark is {2}", D1.GetName(), D1.GetId(), D1.GetPassMark());


				//D1.Name = null;
				//D1.PassMark = 0;

				//Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", D1.ID, D1.Name, D1.PassMark);
			}
		}
}
