using System;
using System.Diagnostics.Metrics;
using System.Reflection;

class Program
{
  static void Main()
  {
      try
      {
          Console.Write(" degree base = ");
          int variable = Convert.ToInt32(Console.ReadLine());

          Console.Write(" base exponent = ");
          int number = Convert.ToInt32(Console.ReadLine());

          if (variable <= 0 || number <= 0)
              throw new ArgumentException("The numbers must be positive");

          long result = PowerByMultiplication(variable, number);
          Console.WriteLine($"Result {variable}^{number}: {result}");
      }
      catch (Exception ex)
      {
          Console.WriteLine("error: " + ex.Message);
      }
      finally
      {
          Console.WriteLine("\nPress any key to exit...");
          Console.ReadKey();
      }
  }
    private static long PowerByMultiplication(int baseNumber, int exponent)
    {
        long result = 1L;
        for (int counter = 0; counter < exponent; ++counter)
        {
            result *= baseNumber;
        }
        return result;
    }
}
