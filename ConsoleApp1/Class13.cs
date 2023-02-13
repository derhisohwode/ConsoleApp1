using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conso
{
	public class stud
	{
		private int _id;
		private string _Name;
		private int _passMark = 35;

		public int Pass
		{
			get {
				return _passMark; 
			}
		}
		public string Name
		{
			set {
				if (string.IsNullOrEmpty(value))
				{
					throw new Exception("name cannot be null or empty");
				}
				this._Name = value;
			}
			get {
				return string.IsNullOrEmpty(this._Name) ? "No name" : this._Name; 
			}
		}
		public int Id
		{
			set
			{
				if (value <= 0) 
				{
					throw new Exception("The ID cannot be a Negative number");
				}
				this._id = value;
			}
			get
			{
				return this._id;
			}
		}
		//public int GetPassMark() 
		//{ 
		//	return this._passMark; 
		//}

		//public void SetName(string name)
		//{
		//	if (string.IsNullOrEmpty(name))
		//	{
		//		throw new Exception("Name cannot be left Empty");
		//	}
		//	this._Name = name;
		//}

		//public string GetName()
		//{
		//	if (string.IsNullOrEmpty(this._Name))
		//	{
		//		return "no name";
		//	}
		//	else
		//	{
		//		return this._Name;
		//	}
		//}

		//public void SetId(int id)
		//{
		//	if (id <= 0)
		//	{
		//		throw new Exception("Id cannot be a neghative number");
		//	}
		//	this._id = id;
		//}

		//public int GetId()
		//{
		//	return this._id;
		//}

	}

	public class Class13
	{
		public static void Main6()
		{
			stud D1 = new stud();
			D1.Id = 101;
			D1.Name = "wright";

			Console.WriteLine("Dear {0}, your Name is {1} and PassMark is {2}", D1.Id, D1.Name, D1.Pass);

			//Console.WriteLine("Dear {0}, your ID is {1} and PassMark is {2}", D1.GetName(), D1.GetId(), D1.GetPassMark());


			//D1.Name = null;
			//D1.PassMark = 0;

			//Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", D1.ID, D1.Name, D1.PassMark);
		}
	}
}
