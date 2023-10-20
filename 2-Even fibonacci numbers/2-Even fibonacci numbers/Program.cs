using System;

namespace _2_Even_fibonacci_numbers
{
    internal class Program
    {
        int FindFibonacci()
        {
            int limit = 4000000, a = 1, b = 1, c = 0, sum = 0;

            while (c < limit)
            {
                c = a + b;
                a = b;
                b = c;

                if (c % 2 == 0)
                    sum += c;
            }

            Console.WriteLine("The sum of Fibonacci numbers less than 4 million divisible by 2: " + sum.ToString());
            
            return 0;
        }
        
        public static void Main(string[] args)
        {
            Program pr = new Program();
            pr.FindFibonacci();
        }
    }
}
