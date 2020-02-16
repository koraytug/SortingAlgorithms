using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertationSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5,3,4,4,8,6 wil sort.... ");
            Console.WriteLine("sorting.... ");

            int[] numberArray = { 5, 3, 4, 4, 8, 6 };

            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numberArray[j-1] > numberArray[j])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j -1];
                        numberArray[j -1] = temp;
                    }
                }

            }
            foreach (int num in numberArray)
            {
                Console.Write("\t {0}", num.ToString());
            }
            Console.WriteLine();

        }
    }
}
