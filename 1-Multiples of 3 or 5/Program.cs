using System;

namespace _1_Multiples_of_3_or_5
{
    internal class Program
    {
        int FindMultiples()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                    sum = sum + i;
            }

            return sum;
        }
        
        public static void Main(string[] args)
        {
            Program pr = new Program();
            Console.WriteLine(pr.FindMultiples());
        }
    }
}