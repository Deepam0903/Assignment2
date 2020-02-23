using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = {2,5,5,2};
            int[] num2 = {5,5};
            int[] intersect = Intersect1(num1, num2);
            
            foreach(int n in intersect)
            {
                Console.WriteLine(n + " " );
            }
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                Array.Sort(nums1);  //Sorting the array 
                Array.Sort(nums2);
                int j = 0;
                int len1 = nums1.Length;
                int len2 = nums2.Length;
                List<int> intList = new List<int>();  //Creating a list object 

                foreach (int i in nums1) 
                    //Logic to check if the number is present in the other array. 
                    //If present add it into list
                {
                    if (i == nums2[j])
                    {
                        intList.Add(i);
                        j++;
                    }

                }

                int[] result = intList.ToArray();
                return result;
            }
            catch
            {
                throw;
            }

        }
    }



}
