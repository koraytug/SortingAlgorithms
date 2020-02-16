using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,8,2,1,5,4,6,7 wil sort.... ");
            Console.WriteLine("sorting.... ");

            List<int> nums =new List<int> { 3, 8, 2, 1, 5, 4, 6, 7 };
            List<int> sorted;
            
            sorted = mergeAndSort(nums);
            printArray(sorted, "sort sonrası içerik  ");
            Console.ReadLine();
        }

        private static List<int> mergeAndSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            printArray(left, "left içerik öncesi mergeAndSort  ");
            printArray(right, "right içerik öncesi mergeAndSort ");

            left = mergeAndSort(left);
            right = mergeAndSort(right);
            printArray(left,"left içerik  ");
            printArray(right, "right içerik  ");
            return mergeArray(left, right);
        }

        private static void printArray(List<int> array, string message)
        {
            /* foreach (int x in array)
             {
                 Console.Write(x + " ");
             }
             Console.Write("\n");*/
            foreach (int num in array)
            {
                Console.Write("\t {0}", num.ToString());
            }
            Console.WriteLine("       "+message);

        }

        private static List<int> mergeArray(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());

                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());

                }
            }

            return result;
        }
    }
}
