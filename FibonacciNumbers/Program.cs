using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to get fibonnacci");
            string num = Console.ReadLine();
            Console.WriteLine(getFibonocciNumber(int.Parse(num)).ToString());
            Console.ReadLine();
        }

        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {                
                return Fib(n - 1) + Fib(n - 2);
            }
        }


        public static int getFibonocciNumber(int index)
        {
            if (index == 1)
            {
                return 1;
            }
            if (index == 0)
            {
                return 0;
            }

            int[] numbers = new int[index+2];
            int result = 0;
            numbers[0] = 0;
            numbers[1] = 1;
            if (index > 1)
            {
                for (int i = 2; i <= index ; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }
                result = numbers[index];
            }

            return result;
        }
    }
}
