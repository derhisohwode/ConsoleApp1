using System;
using System.IO;

public class InnerExceptions
{
    public static void Main21()
    {
       try
        {
            try
            {
                Console.WriteLine("Input a number 0-9");
                int Num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input another number 0-9");
                int Num2 = Convert.ToInt32(Console.ReadLine());

                int tot = Num2 / Num1;
                Console.WriteLine("Result = {0}", tot);
            }
            catch (Exception ex)
            {
                string filestorer = @"C:\samlefiles\store1.txt";
                if (File.Exists(filestorer))
                {
                    StreamWriter storer = new StreamWriter(filestorer);
                    storer.WriteLine(ex.GetType().Name);
                    storer.Write(ex.ToString());
                    storer.Close();
                    //don't do this becaus hackers can use this information to cause harm to our systems
                    //Console.WriteLine(ex.ToString());
                    //Console.WriteLine($"error is {ex.Message}");
                    //Console.WriteLine($"error is {ex.StackTrace}");

                    //instead
                    Console.WriteLine("There was an error pls try again later, thank you");
                }
                else
                {
                    filestorer = @"C:\samlefiles\storeBackup.txt";
                    StreamWriter storer;
                    storer = new StreamWriter(filestorer);
                    storer.WriteLine(ex.GetType().Name);
                    storer.Write(ex.ToString());
                    storer.Close();

                    throw new FileNotFoundException(filestorer + "is not present and is logged to backup", ex);
                }
            }
        } catch (Exception except)
        {
            Console.WriteLine("this is the current exception = {0}", except.GetType().Name);
            string filestorer = @"C:\samlefiles\storeBackup1.txt";
            StreamWriter storer;
            storer = new StreamWriter(filestorer);
            storer.WriteLine(except.GetType().Name);
            if (except.InnerException != null)
            {
                Console.WriteLine("this is the current exception = {0}", except.InnerException.GetType().Name);
                storer.Write(except.InnerException.GetType().Name);
            }
            storer.Close();
        }
    }
}