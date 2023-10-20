using System;

namespace _4_Largest_palindrome_product
{
    internal class Program
    {
        bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            int lastIndex = numStr.Length - 1;

            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[lastIndex])
                    return false;
                else
                    lastIndex--;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            
            int largestProduct = -1;

            for (int i = 999; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (program.IsPalindrome(i * j) && i * j > largestProduct)
                    {
                        largestProduct = i * j;
                        break;
                    }
                }
            }

            Console.WriteLine("Largest palindrome product is: " + largestProduct.ToString());
        }
    }
}
