using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1,8,2,3,5,4,6.7 wil sort.... ");
            Console.WriteLine("sorting.... ");

            int[] nums = { 1, 8, 2, 3, 5, 4, 6, 7 };

            for (int i = 0;i<nums.Length-1; i++)
            {
                int minNumIndex = findMinIndex(i, nums);
                int curNum = nums[i];
                nums[i] = nums[minNumIndex];
                nums[minNumIndex] = curNum;
            }

            foreach (int num in nums)
            {
                Console.Write("\t {0}", num.ToString());
            }
            Console.WriteLine();

            Console.ReadLine();
        }


        private static int findMinIndex(int start,int[] nums)
        {
            int minIndex = start ;
           
            for(int i = start+1;i<nums.Length;i++)
            {
                if (nums[i] <= nums[minIndex])
                {
                    minIndex = i;
                }
                 
            }

            return minIndex;
        }
    }
}
