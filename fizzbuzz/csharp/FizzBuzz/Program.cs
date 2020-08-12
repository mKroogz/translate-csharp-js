using System;

namespace FizzBuzz
{
    class Program
    {
        static void FizzBuzzer(int n)
        {
            if (n % 15 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(n);
            }
            if (n < 100){
                FizzBuzzer(n + 1);
            }
        }

        static void Main(string[] args)
        {
            FizzBuzzer(1);
        }
    }
}
