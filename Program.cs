using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write(" degree base = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" base exponent = ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (a <= 0 || n <= 0)
                throw new ArgumentException("Числа должны быть положительными!");

            long result = PowerByMultiplication(a, n);
            Console.WriteLine($"Результат {a}^{n}: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

    // Функция возведения в степень путем последовательного умножения
    private static long PowerByMultiplication(int baseNum, int exponent)
    {
        long res = 1L;
        for (int i = 0; i < exponent; ++i)
        {
            res *= baseNum;
        }
        return res;
    }
}