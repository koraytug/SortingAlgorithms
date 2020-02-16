using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 3, 7, 4, 4, 6,5, 8 };
           // bool flag = true;
            int temp;
            int numLength = number.Length;

            //sorting an array  
            for (int i = 1; (i <= (numLength - 1)); i++)
            {
               // flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                       // flag = true;
                    }
                }
            }

            //Sorted array  
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }

     

    }

}
