using System;
using System.IO;

public class ExceptionHandlin
{
    public static void Main20()
    {

        StreamReader streamReader = null;


        try //Exception handling using try and catch method
        {
            streamReader = new StreamReader("C:\\samlefiles1\\Document1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        //catch (Exception ex)  
        catch (FileNotFoundException ex)
        {
            //don't do this becaus hackers can use this information to cause harm to our systems
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(ex.Message);
            //Console.WriteLine();
            //Console.WriteLine(ex.StackTrace);
           
            //Console.WriteLine("Please check if the file {0} exists",ex.FileName);//this is a specific exception class which inherits
            //from exception it throw the file not found error

            //instead
            Console.WriteLine("There was an error pls try again later, thank you");
        }
        catch (Exception ex)
        {
            //don't do this becaus hackers can use this information to cause harm to our systems
            //Console.WriteLine($"{ex.Message}", ex);//this is used incase the error is not what you thought of the Exception Class
            //contains all kind of error that might occur in the code
            //instead
            Console.WriteLine("There was an error pls try again later, thank you");
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("done");
        }



        try //Exception handling using try and catch method
        {
            streamReader = new StreamReader("C:\\samlefiles\\Document1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        //catch (Exception ex)  
        catch (FileNotFoundException ex)
        {
            //don't do this becaus hackers can use this information to cause harm to our systems
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(ex.Message);
            //Console.WriteLine();
            //Console.WriteLine(ex.StackTrace);
            //Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            
            //instead
            Console.WriteLine("There was an error pls try again later, thank you");
        }
        catch (Exception ex)
        {
            //don't do this becaus hackers can use this information to cause harm to our systems
            //Console.WriteLine($"{ex.Message}", ex);

            //instead
            Console.WriteLine("There was an error pls try again later, thank you");
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("done");
        }



        try //Excetion handling
        {
            streamReader = new StreamReader(@"C:\samlefiles\Document.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        //catch (Exception ex)  
        catch (FileNotFoundException ex)
        {
            //don't do this becaus hackers can use this information to cause harm to our systems
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(ex.Message);
            //Console.WriteLine();
            //Console.WriteLine(ex.StackTrace);
            //Console.WriteLine("Please check if the file {0} exists", ex.FileName);

            //instead
            Console.WriteLine("There was an error pls try again later, thank you");
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("done");
        }
    }
}