using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ7
{
    internal class Program
    {        
        static void Main()
        {
            int[] numbers = { 5, 10, 20 };

            foreach (var number in numbers)
            {
                Cycle(number);
                Recursive(number);
                Console.WriteLine();
            }
        }

        static Stopwatch stopwatch = new();

        static void Cycle(int number)
        {
            stopwatch.Start();

            int result = 1;
            int previous = -1;
            int sum;

            for (int i = 0; i <= number; i++)
            {
                sum = result + previous;
                previous = result;
                result = sum;
            }

            stopwatch.Stop();
            Console.WriteLine($"[{number}] = {result} , время работы цикла = {stopwatch.Elapsed}");
        }

        static void Recursive(int number)
        {
            stopwatch.Start();

            int result = RecursiveFibonacci(number);

            stopwatch.Stop();
            Console.WriteLine($"[{number}] = {result} , время работы рекурсии = {stopwatch.Elapsed}");
        }

        static int RecursiveFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return RecursiveFibonacci(number - 1) + RecursiveFibonacci(number - 2);
        }

    }
}