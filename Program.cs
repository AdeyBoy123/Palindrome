using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check: ");
                {
                string input = Console.ReadLine();

                if (IsPalindrome(input))
                {
                    Console.WriteLine("Palindrome");
                } 
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
            }
        }

        public static bool IsPalindrome(string input)
        {
            return input == new string(input.Reverse().ToArray());
        }
    }
}
