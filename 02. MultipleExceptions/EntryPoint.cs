using System;

class EntryPoint
{
    static void Main()
    {
        //try
        //{
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    int secondNumber = Convert.ToInt32(Console.ReadLine());

        //    int result = number / secondNumber;
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Your input was not a number!");
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("You can not divide by zero!");
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("Unexpected error!");
        //}

        //Console.WriteLine("After the try/catch block");


        try
        {

            int[] array = { 1, 2, 3, 4, 5, 0, 0, 6, 7, 8 };

            int number = Convert.ToInt32(Console.ReadLine());
            int calculated = 0;

            for (int i = 0; i <= array.Length; i++)
            {
                calculated = number / array[i];
                Console.WriteLine(array[i]);
            }
        }
        catch (FormatException ex)
        {
            int startIndex = ex.StackTrace.IndexOf(':') - 1;
            int length = ex.StackTrace.Length - startIndex;
            string fileName = ex.StackTrace.Substring(startIndex, length);

            Console.WriteLine(ex.Message);
            Console.WriteLine(fileName);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Attempted to divide by zero!");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Attempted to access non-existent element from the array! Index out of range!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error!");
        }
    }
}
