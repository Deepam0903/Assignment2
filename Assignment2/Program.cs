using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Question 1");
             int[] l1 = new int[] { 5, 6, 6, 12 };
             int target = 9;
             int[] r = TargetRange(l1, target);
             for (int z = 0; z <= r.Length - 1;z++) 
             {
                if (z != r.Length - 1)
                    Console.Write(r[z] + ",");
                else
                    Console.Write(r[z] + "");
            }


              Console.WriteLine();
              Console.WriteLine("Question 2");
              string s = "University of South Florida";
              string rs = StringReverse(s);
              Console.WriteLine(rs);
              Console.WriteLine();


              Console.WriteLine("Question 3");
              int[] l2 = new int[] { 2, 2, 3, 5, 6 };
              int sum = MinimumSum(l2);
              Console.WriteLine(sum);
              Console.WriteLine();

              Console.WriteLine("Question 4");
              string s2 = "Dell";
              string sortedString = FreqSort(s2);
              Console.WriteLine(sortedString);

           //Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
           /*int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);*/
            Console.WriteLine("\n");

            Console.WriteLine("Question 5-Part 2");
             int[] intersect2 = Intersect2(nums1, nums2);
             Console.WriteLine("Part 2- Intersection of two arrays is: ");
             DisplayArray(intersect2);
             Console.WriteLine();

             Console.WriteLine("Question 6");
             char[] arr = new char[] { 'a', 'g', 'h', 'a' };
             int k = 3;
             Console.WriteLine(ContainsDuplicate(arr, k));
             Console.WriteLine();

             Console.WriteLine("Question 7");
             int rodLength = 4;
             int priceProduct = GoldRod(rodLength);
             Console.WriteLine(priceProduct);
             Console.WriteLine();

           /*  Console.WriteLine("Question 8");
             string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
             string keyword = "hhllo";
             Console.WriteLine(DictSearch(userDict, keyword));
             Console.WriteLine();

            // Console.WriteLine("Question 9");
            //SolvePuzzle();*/
        }

        private static void DisplayArray(int[] intersect2)
        {
            for(int i =0; i <= intersect2.Length-1;i++)
            {
                Console.WriteLine(intersect2[i]);
            }
        }

        /* public static void DisplayArray(int[] a)
         {
             foreach (int n in a)
             {
                 Console.Write(n + " ");
             }


         }*/
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                int[] y = new int[l1.Length];// declaring a new array y and initializing it with -1 as the vaue for 0th index.
                y[0] = -1;
                int[] x = new int[] { };// declaring an empty array x.

                for (int i = 0; i <= l1.Length - 1; i++) // the Loop will run fromm 0 through length of l1 - 1.
                {
                    if (l1[i] == t) //If i th element of array l1 is eual to target then it assigns y[0] with the i value 
                    {
                        y[0] = i;
                        Array.Resize(ref x, x.Length + 1);// array x is resized to store Legnth +1 elements
                        x[x.Length -1] = i; //i value is stored in x
                    }

                    if (i == (l1.Length - 1) && y[0] == -1)// if i is the last index in array and y[0] is still -1
                    {
                        Array.Resize(ref x, 2); // the array x is resized to hold 2 elements and stores -1 value at both the index.
                        x[0] = -1;
                        x[1] = -1;
                        break;
                    }

                }
                return x;

            }

            catch (Exception)
            {
                throw;
            }
        }

        public static string StringReverse(string s)
        {
            try
            {
                String str = ""; // Empty string declared to split the string
                String str1 = "";// to store the split string
                String str2 = ""; // to return the reversed string

                for (int i = 0; i <= s.Length - 1; i++) //Loop will run from 0 to legnth of string
                {
                    if (s[i] != ' ') // if there is no space the loop will keep on adding the characters to the string str
                    {
                        str = str + s[i];
                        if (i != s.Length - 1)
                            continue;
                    }

                    str1 = str + " ";// the string str1 will store the contents of the split string along with a space
                    str = ""; //make str empty again
                    for (int j = str1.Length - 1; j >= 0; j--) // this loop will reverse the contents of the string str1
                    {
                        str2 = str2 + str1[j];// str2 will hold the contents of str1 in a reversed order.
                    }
                }
                return str2;// string 2 is returned.
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int MinimumSum(int[] l2)
        {
            int sum = 0;// initialized sum =0
            try
            {
                for(int i=0;i<=l2.Length -1;i++) //the loop will run from 0 to the length of the integer array
                {
                   
                    sum = sum + l2[i]; // sum will be sum + the element present at ith index
                    if (i != l2.Length -1 && l2[i+1]== l2[i]) // if the element is not the last element and two consecutive elements are equal, then it will increment the i+1th element by 1.
                    {
                        l2[i + 1] = l2[i + 1] + 1;
                    }
                }
                return sum;
            }
           
            catch (Exception)
            {
                throw;
            }
          
        }
        public static string FreqSort(string s2)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();// initializing a dictionary dict
            string str = "";// initializing an empty string
            int temp = 0;// initializing temp variable to keep the count as 0
            try
            {
                for (int i = 0; i <= s2.Length - 1; i++)// the Loop will run from 0 to the Length of input string
                {
                    if (dict.ContainsKey(s2[i]))// if the dictionary already contains the key (letter in string s2)
                    {
                        temp = temp + 1; // the temp count will increase by 1 each time same letter is encountered in the String
                        dict[s2[i]] = temp;//the Value will get updated accordingly with the Frequency
                    }
                    else
                    {
                        dict.Add(s2[i], temp);// the dictionarry will add the letter as key if it doesn't already exist in the dictionary
                    }
                }
                foreach (KeyValuePair<char, int> k in dict.OrderByDescending(key => key.Value))// Orderby Descending will sort the dictionary as per the Value i.e. the frequency of occurence of a letter
                {
                    for (int i = 0; i <= k.Value; i++)// the loop will run from 0 to the number of times the letter is encountered in the dictionary.
                    {
                        string str2 = k.Key.ToString();// it will store the letter(s)
                        str = str + str2;
                    }
                }
                return str;//this string contains the string in descending order of frequency. 
            }

            catch (Exception)
            {
                throw;
            }
        }
    
   /* public static int[] Intersect1(int[] nums1, int[] nums2)
         {
             try
             {
                 // Write your code here
             }
             catch
             {
                 throw;
             }
             return new int[] { };
         }*/
         public static int[] Intersect2(int[] nums1, int[] nums2)
         {
            try
            {
                int[] x = new int[] { };
                Dictionary<int, int> dict = new Dictionary<int, int>();
                int j = 0;
                for (int i = 0; i <= nums1.Length - 1; i++)// The Loop will run from 0 to the Length of num1 array
                {
                    dict.Add(i, nums1[i]); // It will add all the elements of nums1 array in the dictionary

                }
                foreach (KeyValuePair<int, int> k in dict)
                {
                    if (j != nums2.Length && dict.ContainsValue(nums2[j])) // this condition tests if the dictionary contains the Value of nums2 at jth location 
                    {
                        Array.Resize(ref x, x.Length + 1);// It will add modify the size of array as per the number of elements that match
                        x[j] = nums2[j];
                        j++;// if the element is matched then it will increment the value of j

                    }
                    else if (j == nums2.Length)
                    {
                        break;
                    }
                }
                return x;
            }
            catch
            {
                throw;
            }
            
         }
        public static bool ContainsDuplicate(char[] arr, int k)
            {
                try
                {
                   bool a;
                    Dictionary<int, char> dict = new Dictionary<int, char>();

                    for (int i = 0; i <= arr.Length - 1; i++)
                    {
                        dict.Add(i, arr[i]);
                    }
                    //Creating a look up table which will note down the index values for the character
                     var lookup = dict.ToLookup(z => z.Value, z => z.Key).Where(z => z.Count() > 1);
                //iterating through the look up values to find the difference between the index values
                    foreach (var item in lookup)
                     {
                         var keys = item.Aggregate("", (t, u) => t + ", " + u);
                    //Substracting the 2nd occurence of the character with the first to get the absolute difference
                         int diff = keys.ElementAt(5) - keys.ElementAt(2);
                    //Check if the difference is equal to the target value 
                         if (diff >= k)
                          {
                        //return true if difference is equal, else return false
                             a = true;
                             return a;
                         }
                     }
                return false;

              
                 }

            catch (Exception)
            {
                throw;
            }
        }

       public static int GoldRod(int rodLength)
            {
                try
                {
                     int max = rodLength;
                     for (int i = rodLength - 1; i > 0; i--) // The loop will run from length of rod -1 through 1
                     {
                         int temp = GoldRod(i);//The temp variable will store the value after calling the method GoldRod again
                         temp *= (rodLength - i);// temp variable will hold the vallue of temp  * rodlength-i
                         if (temp > max)// this will check the condition if temp is greater than max
                            max = temp;// if the above condition is true, max will store the value of temp.
                     }
                    return max;
                }
                catch (Exception)
                {
                    throw;
                }
               
            }

      /* public static bool DictSearch(string[] userDict, string keyword)
        {
           try
           {

           
           }

        catch (Exception)
        {
            throw;
        }
        return default;
    }
        public static void SolvePuzzle()
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
        }*/

    }
}


