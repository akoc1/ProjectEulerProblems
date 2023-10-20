using System;

namespace _3_Largest_prime_factor
{
    internal class Program
    {
        bool IsPrime(long n) // reference: https://en.wikipedia.org/wiki/Primality_test
        {
            if (n <= 1 && (n % 2 == 0 || n % 3 == 0))
                return false;

            if (n == 2 || n == 3)
                return true;

            for (long i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Program pr = new Program();

            long number = 600851475143;
            long biggestFactor = 0;

            for (long i = 2; i <= number; i++)
            {
                if (number % i == 0 && pr.IsPrime(i))
                {
                    biggestFactor = i;
                    number /= i;
                }
            }

            Console.WriteLine("Biggest prime factor of 600851475143 is: " + biggestFactor.ToString());
        }
    }
}
