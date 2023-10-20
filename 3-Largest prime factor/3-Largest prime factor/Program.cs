using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Largest_prime_factor
{
    internal class Program
    {
        bool IsPrime(int n) //reference: https://en.wikipedia.org/wiki/Primality_test
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        
        public static void Main(string[] args)
        {
            Program pr = new Program();
            
            double number = 600851475143;
            List<int> factors = new List<int>();

            for (int i = 3; i < number; i+=2)
            {
                if (pr.IsPrime(i) && number % i == 0)
                {
                    factors.Add(i);
                }
            }

            foreach (int num in factors)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}