using System;
using System.IO;

class EntryPoint
{
    static void Main()
    {
        StreamWriter sw = null;

        if (File.Exists())
        {
            File.Open();
        }


        try
        {
            sw = File.AppendText(Directory.GetCurrentDirectory() + @"\test.txt");

            int number = Convert.ToInt32(Console.ReadLine());
            int divided = 5 / number;

            sw.Write(divided);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sw.Close();
        }

        try
        {
            StreamReader sr = File.OpenText(Directory.GetCurrentDirectory() + @"\test.txt");
            Console.WriteLine(sr.ReadToEnd());
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}