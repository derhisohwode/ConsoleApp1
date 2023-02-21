using System;
using System.IO;

public class ExceptionHandlingAbuse
{
    public static void Main23()
    {
        int fisrtNum;
        int secondNum;
        
       try
        {
			Console.WriteLine("Enter the first number");
			fisrtNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Enter the second number");
			secondNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("The first number is {0}", fisrtNum);
			Console.WriteLine("The second number is {0}", secondNum);

			int Total = fisrtNum / secondNum;
			Console.WriteLine("The result of the division is {0}", Total);
		}
		catch (FormatException ex)
		{
			Console.WriteLine(ex.Message);
			Console.WriteLine("wrong format");
		}
		catch (OverflowException ev)
		{
			//string filestorer = @"C:\samlefiles\storeBackup1.txt";
			//StreamWriter streamWriter = new StreamWriter(filestorer);
			//streamWriter.WriteLine(ev.ToString());
			//Console.WriteLine("check log for error info");
			Console.WriteLine(ev.Message);
			Console.WriteLine("cannot input a number less than {0} or greater than {1}", Int32.MinValue, Int32.MaxValue);
		}
		catch (DivideByZeroException ez)
		{
			Console.WriteLine(ez.Message);
			Console.WriteLine("your second number cannot be zero");
		}
		catch (Exception ee)
		{
			Console.WriteLine(ee.ToString());
			Console.WriteLine("didnt plan for this");
		}
    }
}