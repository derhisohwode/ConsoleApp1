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
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(ex.Message);
            //Console.WriteLine();
            //Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Please check if the file {0} exists",ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}", ex);
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
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(ex.Message);
            //Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Please check if the file {0} exists", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}", ex);
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
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(ex.Message);
            //Console.WriteLine();
            //Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Please check if the file {0} exists", ex.FileName);
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