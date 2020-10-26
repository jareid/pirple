using System;

namespace Homework5
{
    class Primes
    {
        public bool IsPrime(int number)
        {
            int max = 0;
            bool flag = true;
            max = number / 2;
            for (int i = 2; i <= max; i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var primeCheck = new Primes();
            for (int i = 1; i < 100; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.Write("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.Write("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(i);
                }

                if (primeCheck.IsPrime(i))
                {
                    Console.WriteLine(" and prime");
                } else
                {
                    Console.WriteLine("");
                }
            }

        }
    }
}
